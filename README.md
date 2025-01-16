# Grupp-7 | C# Konsolapplikation för kontroll av Personnummer


![example workflow](https://github.com/KorpenM/Grupp-7/actions/workflows/testing.yml/badge.svg)  
![example workflow](https://github.com/KorpenM/Grupp-7/actions/workflows/docker.yml/badge.svg)  


# Applikationen

Den här applikationen kontrollerar svenska personnummer.
Användaren ombeds att mata in ett svenskt personummer (format YYMMDDXXXX) och applikationen veriferar att numret är korrekt.
Samt så ber applikationen använder att ange om dom föddes innan millennieskiftet, vilket hjälper den att beräkna om dom redan har fyllt 100. 
Om användaren skulle vara 100 år gammal så kommer applikationen att använda korrekt format när den skriver ut deras personnummer.

# Installation och Användning (Locally)

För att köra programmet lokalt:

1. Clone repository:
'''bash
git clone https://github.com/KorpenM/Grupp-7.git
'''

2. Navigate to the folder:
'''bash
cd Grupp-7
'''

3. Restore potential issues and build:
'''bash
dotnet restore
dotnet build
'''

4. (3.5) For testing:
'''bash
dotnet test
'''

5. Run application:
'''bash
dotnet run
'''

6. Applikationen kommer fråga efter inmatning av personnummer.
Följ instruktionerna för att verifiera personnummer.



# Docker - Build and Run app

För att köra programmet i en Docker-Container:

1. **Bygg Docker-image:**
'''bash
docker build -t korpenm/grupp-7 .
'''

2. **Kör Docker-Containers:**
'''bash
docker run -it korpenm/grupp-7
'''

3. **Använd applikationen:**
När containern körs kommer applikationen att fråga efter ett svenskt personnummer för att verifiera att det är korrekt.



## GitHub Actions och Kontinuerlig Integration

Vi har konfigurerat GitHub Actions för att automatisera följande:

- **Bygg och Testa applikationen:** - När en ändring pushas till main-grenen körs enhetstesterna via 'testing.yml'
- **Bygg och Publicera Docker-container:** - När en ändring pushas till main byggs Docker-containern och publiceras på DockerHub via `docker.yml'

För att se resultaten av testerna eller byggflödena, navigera till *Actions*-fliken i GitHub.

- [Unit Test Workflow (testing.yml)](https://github.com/<username>/<repo>/actions/workflows/testing.yml)
- [Docker Publish Workflow (docker.yml)](https://github.com/<username>/<repo>/actions/workflows/docker.yml)


## Personnummer i Sverige

Ett svenskt personnummer är ett unikt identifieringsnummer som används för att identifiera individer inom Sveriges officiella system,
och är en viktig del av det svenska folkbokföringssystemet.
Personnumret består av 10 siffror och följer ett specifikt format, där de första siffrorna representerar födelsedatumet,
följt av ett löpnummer, och slutligen en kontrollsiffra.

YYMMDD: Första sex siffrorna representerar födelsedatumet i formatet år (YY), månad (MM) och dag (DD).
XXXX: Fyra sista siffrorna är ett unikt löpnummer som identifierar individen.
De tre första siffrorna i detta nummer används för att särskilja individer som är födda på samma dag,
medan den sista siffran är en kontrollsiffra som används för att säkerställa att numret är korrekt.

I dom flesta fall så används ett bindestreck (-) för att koppla födelsedatum med löp- och kontrollnummer (YYMMDD-XXXX), 
men om en person skulle fylla 100 så används ett plustecken istället vid formateringen av deras personnummer (YYMMDD+XXXX). 

Applikationen verifierar om ett inmatat personnummer har korrekt längd, om alla tecken är numeriska, och om numret följer det svenska formatet.

För detaljer om personnummer: [Wikipedia: Personnummer i Sverige](https://sv.wikipedia.org/wiki/Personnummer_i_Sverige)



## Eventuella Förbättringar

- Lägg till mer avancerad validering (t.ex. kontroll av födelsedatumets giltighet).
- Integrera med externa API-tjänster för att validera personnummer mot offentliga register.
