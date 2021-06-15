# Spis treści
- [Treść zadania](#treść-zadania "Treść zadania")
- [Opis zadania](#opis-zadania "Opis zadania")
- [Środowisko pracy](#środowisko-pracy "Środowisko pracy")
- [Użyte biblioteki](#użyte-biblioteki "Użyte biblioteki")
- [Punkty końcowe](#punkty-końcowe "Punkty końcowe")

# Treść zadania
Zadanie polega na oprogramowaniu mechanizmu zarządzania strukturą drzewiastą wraz z implementacją poprawnej obsługi formularzy.

1. Założenia co do technologii:

+ baza danych MSSQL / MySQL / PostgreSQL,
+ ASP.NET / MVC / .NET Core,
+ HTML 5, CSS 3.

2. Założenia dotyczące realizacja zadania:

+ struktura drzewiasta ma umożliwiać działanie na dowolnej ilości poziomów,
+ funkcje jakie mają być dostępne dla administratora: dodawanie, edycja, usuwania, sortowanie (zarówno węzłów jak i liści), przenoszenie węzłów do innych gałęzi,
+ powinna być możliwość rozwinięcia całej struktury lub wybranych węzłów,
+ powinny zostać zastosowane zabezpieczenia uniemożliwiające wprowadzanie nieprawidłowych danych,
+ wskazane zastosowanie skryptów client-side (własnych, nie gotowych rozwiązań jak np. jsTree)
+ obsługa formularzy powinna zawierać klasę do generowania formularzy wraz z wizualizacją, walidacją oraz zabezpieczeniami.

# Opis zadania
**Tree structure API** to prosta aplikacja backendowa napisana w standardzie **REST API** na potrzeby zadania rekrutacyjnego.

# Środowisko pracy
Środowisko w jakim przyszło mi wykonać zadanie.
                    
Narzędzia | Wersja
------------- | :-------------:
C#  | `9.0`
ASP.NET Core | `5.0`
MS SQL Server | `18`

# Użyte pakiety NuGet
Biblioteki i frameworki jakich użyłem do wykonania zadania.

Pakiet Nuget | Opis
------------- | -------------
AutoMapper  | Mapowanie modeli DTO
Entity | Mapowanie baz danych
Swagger | Dokumentacja API
Fluent Validation | Walidacja modeli
JWT Bearer | Logowanie/autoryzacja

# Punkty końcowe
- [x] Aktualnie dostępne
- [ ] Wkrótce dostępne

### api/nodetree
> Pobieranie wszystkich drzew

- [x] **`GET` /api/nodetree/get** 

> Pobieranie drzwa węzłów po unikalnym identyfikatorze {guid}

- [x]  **`GET` /api/nodetree/get/{guid}** 

> Sortowanie {sort}: a-z lub z-a wybranej gałęzi {node} drzewa węzłów {guid}

- [x]  **`GET` /api/nodetree/sort/{guid}/{node}/{sort}** 

> Tworzenie nowego drzewa węzłów przez format json

- [x]  **`POST` /api/nodetree/create**

> Tworzenie nowego węzła w wybranym drzewie {guid}

- [x]  **`PUT` /api/nodetree/create/{guid}**

> Aktualizowanie nazwy węzła w wybranym drzewie {guid}

- [x]  **`PUT` /api/nodetree/update/{guid}**

> Przenoszenie węzła w wybranym drzewie {guid}

- [ ]  **`PUT` /api/nodetree/move/{guid}**

> Usuwanie węzła {node} w wybranym drzewie {guid}

- [x]  **`DELETE` /api/nodetree/delete/{guid}/{node}**

> Usuwanie drzewa węzłów {guid}

- [ ]  **`DELETE` /api/nodetree/delete/{guid}**

### api/account
> Rejestracja użytkownika

- [x]  **`POST` /api/account/register** 

> Logowanie użytkownika

- [x]  **`DELETE` /api/account/login** 
