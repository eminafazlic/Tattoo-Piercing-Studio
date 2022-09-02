using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RS2_seminarski_tattoostudio.Configuration;
using RS2_seminarski_tattoostudio.Database;
using RS2_seminarski_tattoostudio.Filters;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using TattooStudio.Model.Requests;
using TattooStudio.Model.Responses;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public class UposlenikService : BaseCRUDService<TattooStudio.Model.Uposlenik, Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikInsertRequest>, IUposlenikService
    {
        private readonly IOptions<AppSettings> _options;
        public UposlenikService(TattooStudioRSIIContext context, IMapper mapper, IOptions<AppSettings> options)
            :base(context, mapper)
        {
            _options = options;
        }

        public override IList<TattooStudio.Model.Uposlenik> Get(UposlenikSearchObject search = null)
        {
            var entity = _context.Set<Uposlenik>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                entity = entity.Where(x => x.Ime == search.Ime);
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                entity = entity.Where(x => x.Prezime == search.Prezime);
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                entity = entity.Where(x => x.KorisnickoIme == search.KorisnickoIme);
            }
            if (search?.SpolId.HasValue == true)
            {
                entity = entity.Where(x => x.SpolId == search.SpolId);
            }
            if (search?.SviTattooArtisti == true)
            {
                entity = entity.Where(x => x.ZanimanjeId != 1);
            }
            else
                if (search?.ZanimanjeId.HasValue == true)
                {
                    entity = entity.Where(x => x.ZanimanjeId == search.ZanimanjeId);
                }
            entity.Include(x => x.Spol).Include(x => x.Zanimanje);
            var result = entity.ToList();
            return _mapper.Map<IList<TattooStudio.Model.Uposlenik>>(result);
        }

        public override TattooStudio.Model.Uposlenik Insert(UposlenikInsertRequest request)
        {
            var entity = _mapper.Map<Uposlenik>(request);
            if (_context.Uposleniks.Where(x => x.KorisnickoIme == request.KorisnickoIme).Any())
            {
                throw new UserException("Korisničko ime je zauzeto");
            }
            if (request.Lozinka != request.PotvrdiLozinku)
            {
                throw new UserException("Lozinke se ne podudaraju");
            }
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            _context.Uposleniks.Add(entity);
            _context.SaveChanges();
            var noviUposlenik = _context.Uposleniks.Where(x => x.KorisnickoIme == request.KorisnickoIme).FirstOrDefault();
            Portfolio portfolio = new Portfolio
            {
                UposlenikId = noviUposlenik.UposlenikId
            };
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return _mapper.Map<TattooStudio.Model.Uposlenik>(entity);
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public override TattooStudio.Model.Uposlenik Update(int id, UposlenikInsertRequest request)
        {
            var entity = _context.Uposleniks.Find(id);
            _mapper.Map(request, entity);
            if (!string.IsNullOrWhiteSpace(request.Lozinka) && !string.IsNullOrWhiteSpace(request.PotvrdiLozinku))
            {
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }
            else
            {
                throw new UserException("Promjene nisu sačuvane");
            }
            _context.SaveChanges();
            if (!string.IsNullOrWhiteSpace(request.Lozinka))
            {
                if (request.Lozinka != request.PotvrdiLozinku)
                {
                    throw new UserException("Lozinke se ne podudaraju");
                }
            }
            _context.SaveChanges();
            return _mapper.Map<TattooStudio.Model.Uposlenik>(entity);
        }

        public override bool Delete(int id)
        {
            if (id != 0)
            {
                var obavijesti = _context.Obavijests.Where(x => x.UposlenikId == id).ToList();
                foreach (var x in obavijesti)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();
                var izvjestaji = _context.Izvjestajs.Where(x => x.UposlenikId == id).ToList();
                foreach (var x in izvjestaji)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();
                var portfolio = _context.Portfolios.Where(x => x.UposlenikId == id).FirstOrDefault();
                if (portfolio != null)
                {
                    var stavkePortfolia = _context.StavkePortfolia.Where(x => x.PortfolioId == portfolio.PortfolioId).ToList();
                    foreach (var x in stavkePortfolia)
                    {
                        _context.Remove(x);
                    }
                    _context.SaveChanges();
                    _context.Remove(portfolio);
                    _context.SaveChanges();
                }
                var termini = _context.Termins.Where(x => x.UposlenikId == id).ToList();
                foreach (var x in termini)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();
                var uposlenik = _context.Uposleniks.Find(id);
                _context.Remove(uposlenik);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public UserAuthenticationResult Authenticate(UserLoginModel userLogin)
        {
            var user = _context.Uposleniks.FirstOrDefault(x => x.KorisnickoIme == userLogin.Username);
            if (user == null)
            {
                throw new UserException("Greška");
            }
            if (user.LozinkaHash != GenerateHash(user.LozinkaSalt, userLogin.Password))
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_options.Value.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UposlenikId.ToString()),
                    new Claim(ClaimTypes.Name, user.KorisnickoIme),
                }),
                Issuer = _options.Value.Issuer,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new UserAuthenticationResult
            {
                Id = user.UposlenikId,
                Token = tokenHandler.WriteToken(token),
                Username = user.KorisnickoIme
            };
        }
    }
}
