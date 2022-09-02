# Tattoo-Piercing-Studio
Seminarski rad iz predmeta Razvoj softvera II


Projekt se sastoji od tri međusobno povezana dijela: REST API C# ASP.NET Core aplikacije, Windows forms aplikacije, Flutter mobilne aplikacije.

#

Pokretanje dokerizovanog API-ja i DB-a

Kloniranje repozitorija: git clone https://github.com/eminafazlic/Tattoo-Piercing-Studio

Otvoriti klonirani repozitorij u cmd konzoli i unijeti slijedeće komande: 

docker-compose build

docker-compose up

#

Pristupni podaci:

Desktop app

	Username: desktop
	
	Password: test1
	
Mobile app

	Username: mobile 
	
	Password: test1


Podaci za Stripe payment servis

	Broj kreditne kartice: 4242 4242 4242 4242 (ili bilo koji drugi broj kartice sa https://stripe.com/docs/testing) 
	
	Exp. date: bilo koji važeći budući datum, npr. 12/34
	
	CVC: bilo koja 3 broja
