## API DOTNET 8 DE GESTION DE BIBLIOTHEQUE

### Introducition

Ce projet est une api faite avec le framwork .NET 8.

Elle permet la gestion d'une bibliothèque de livre

### Prérequis 

- Premierement il faut clonner le depot 
```bash
git clone https://github.com/Emin0342/Cours-dotnet.git
```

- Ensuite il faut telecharger tous les packages nécéssaire a son bon fonctionnement :  

EntityFramework 8 : 

```shell
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
```

Sqlite3
```shell
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.0
```
`SUR WINDOWS IL FAUT EGALEMENT TELECHARGER L'EXECUTABLE SUR LE SITE DE SQLITE, UNE FOIS INSTALLER IL FAUT DEFINIR LA VARIBLE D'ENVIRONNEMENT `

` - SUR LE MENU DEMARER CHERCHER "Modifier les varibles d'environnement système" `

` - CLIKER SUR "Variables d'environnement"`

` - DOUBLE CLICKER SUR "Path" PRESENT DANS VARIBLES SYSTEME PUIS "Nouveau"'`

` - INSERER LE CHEMIN DE L'EXECUTABLE SQLITE3 (Exemple : C:\Users\emins\Documents\sqlite3\sqlite3 )`

`POUR TESTER SI SQLITE EST BIEN INSTALLER LANCER UN CMD ET UTILISER LA COMMANDE : `
```shell
sqlite
```


EntityFramework - Design
```shell
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
```

### Démarrage 

placer vous dans le bon repertoir et lancer la commande :

```cs
dotnet build
```
afin de verifier si il n'y a pas d'erreur

si aucune erreur ne détecter lancer cette commande pour utiliser l'API : 

```cs
dotnet run
```

une fois cela fait il vous suffit de vous rendre a l'URL indiqué dans le cmd : 

```shell
Now listening on: http://localhost:5123
```

Pour voir l'API de manière graphique il faut ajouter `/swagger` a la fin de l'URL

# Requete GET : 

Afin d'éffectuer une requete GET il faut clicker sur `GET` -->  `TRY IT OUT` puis `EXECUTE` et plus bas vous devrez voir toutes les données présente dans la BDD

# Requete POST : 

Afin d'éffectuer une requete POST il faut clicker sur `POST` -->  `TRY IT OUT` et plus bas vous devrez voir toutes les champs avec leur valeur définit par defaut qui peuvent être modifier puis valider le tous avec `EXECUTE`
(pour verifier que tous a bien fonctionner il suffit simplement de faire un nouvelle requete GET (ou get selon l'id pour éviter de chercher parmis plusieur ligne) afin de voir si la nouvelle ligne s'est bien inserer)


# Requete PUT : 

Afin d'éffectuer une requete PUT il faut clicker sur `PUT` -->  `TRY IT OUT`,  preciser l'id de la ligne que l'ont veut modifier et modifier les champs juste en dessous puis faire `EXECUTE`

# REQUETE DELETE : 

Afin d'éffectuer une requete DELETE il faut clicker sur `DELETE` -->  `TRY IT OUT`,  preciser l'id de la ligne que l'ont veut supprimer puis faire `EXECUTE`