# .NET

.NET est un framework de developpement cross plateforme et open source concus par microsoft.

Voici un appercu des technologie .NET 
![Alt text](image.png)

La premiere différence entre .NET et .NET core est que .NET core est open source et cross plateform, tandis que .NET Framework est propriétaire et ne fonctionne que sur windows.

La portabilité de .NET core est possible car il depend pas de windows, mais de CoreCLR, une version de CLR (Commun Language Runtine)

Les librairies NuGets : .NET core utilise les librairies NuGet, qui sont des librairies open-source, tandis que .NET Framework ne sont pas encore portees sur .NET Core. 

## .NET Core 

L'une des premiere technologie introduite par .NET CORE est ASP .NET Core, qui est un framework open-source et cross plateform, qui permet de : 

- d'unifier les API UI et Web API
- d'intégrer les framework client side comme Angular, react, vue
- de s'integrer facilement dans un environnement cloud 
- d'héberger des applcations avec Docker Apache Ngix

## Le pattern MVC 

.NET utilise le pattern MVC (model vue controller) pour developper des app web : 

- Separation des couches logiques, metier et présentation
- Razor pages permet de creer des pages web
- du model Binding et de la validation de model



Voici l'architechture d'un projet .NET console (cf projet), pour en créer une il suffit de taper la commade suivante : 

```bash
dotnet new console
```

 