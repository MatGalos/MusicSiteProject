# MusicSiteProject

## Czym jest ten projekt?
### Jest to projekt zaliczeniowy przedmiotu "Programowanie w środowisku ASP .NET"
## Jakie ma założenia?
### Jest to strona na której można wystawiać opinię o albumach muzycznych w skali od 0 do 5.
### Póżniej można z tego wyciągnąć średnią.
### Pozwala to na poznanie opini innych ludzi o muzyce
## Co mogę zrobić jako niezalogowany użytkownik ?
### Jako niezalogowany użytkownik możesz przejrzeć bazę danych albumów, zobaczyć jakie są utwory na danym albumie, oraz poznać opinię innych użytkowników
## Co mogę zrobić jako zalogowany użytkownik ?
### Jako zalogowany użytkownik możesz zrobić to samo co niezalogowany użytkownik, ponadto możesz wystawiać, modyfikować, oraz usuwać swoją opinię o danym albumie.
## Co robi Admin?
### Admin może usuwać recenzje które naruszają zasady użytkowania.

# Uruchomienie Projektu
## Konfiguracja przed uruchomieniem
### Połączenie z bazą
Zaczynamy od konfiguracji połączenia z bazą.
Najpierw przechodzimy do pliku `appsettings.json`.
Potem szukamy `Data`, `MusicSite` , `ConnectionStarting`.
Jak będziemy tam to ustwaiamy `ConnectionStarting` pod własne połączenie
### Tworzenie bazy
Bazę tworzymy poprzez wpisanie w konsolę menedżera pakietów komend `add-migration MusicSiteDb` `update-database`. Po ich wykonaniu baza danych powinna zostać utworzona
### Koniec Konfiguracji
Na koniec musimy sprawdzić czy wszystkie pakiety zostały pobrane

# Domyślne konta

| Nazwa Użytkownika | Hasło | Rola w bazie
|--|--|--
|MAgick90909|Password1234!|Użytkownik
|User2|Password1234!|Użytkownik
|Admin|Password1234!|Admin
