## API DOTNET 8 DE GESTION DE BIBLIOTHEQUE

### Introducition

Ce projet est une api faite avec le framwork .NET 8.

Elle permet la gestion d'une bibliothèque de livre

### Arborecence

Le projet final se trouve dans le dossier
ApplicationApiView : qui contient 2 dossier
- MVC : contient le projet MVC de l'application afin de pouvoir voir les données de la BDD en faisant des requêtes a l'API
- API : contient le projet de l'API 

Tous le reste des fichiers / dossier ne sont pas necessaire au bon fonctionnement de l'API, il s'agit de projet 
de test ou de projet de cours
### Prérequis 

- Premièrement il faut cloner le dépôt
```bash
git clone https://github.com/Emin0342/Cours-dotnet.git
```

- Ensuite il faut télécharger tous les packages nécessaires à son bon fonctionnement :   

EntityFramework 8 : 

```shell
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
```
Automapper :

```bash
dotnet dotnet add package AutoMapper --version 12.0.1
```

Sqlite3
```shell
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.0
```
`SUR WINDOWS IL FAUT EGALEMENT TELECHARGER L'EXECUTABLE SUR LE SITE DE SQLITE, UNE FOIS INSTALLER IL FAUT DEFINIR LA VARIBLE D'ENVIRONNEMENT `

` - SUR LE MENU DEMARER CHERCHER "Modifier les variables d'environnement système" `

` - CLIKER SUR "Variables d'environnement"`

` - DOUBLE CLICKER SUR "Path" PRESENT DANS VARIBLES SYSTEME PUIS "Nouveau"'`

` - INSERER LE CHEMIN DE L'EXECUTABLE SQLITE3 (Exemple : C:\Users\emins\Documents\sqlite3\sqlite3)`

`POUR TESTER SI SQLITE EST BIEN INSTALLER LANCER UN CMD ET UTILISER LA COMMANDE : `
```shell
sqlite
```


EntityFramework - Design
```shell
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
```

### Démarrage 

Placez-vous dans le bon répertoire et lancez la commande :

```cs
dotnet build
```
Afin de verifier s'il n'y a pas d'erreur

Si aucune erreur n'est détecter lancer cette commande pour utiliser l'API : 

```cs
dotnet run
```

Une fois cela fait il vous suffit de vous rendre à l'URL indiqué dans le cmd : 

```shell
Now listening on: http://localhost:5123
```

Pour voir l'API de manière graphique il faut ajouter `/swagger` à la fin de l'URL

# Requete GET : 

Afin d'effectuer une requête GET il faut clicker sur `GET>  `TRY IT OUT` puis `EXECUTE` et plus bas vous devrez voir toutes les données présente dans la BDD

# Requete POST : 

Afin d'effectuer une requête POST il faut clicker sur `POST` -->  `TRY IT OUT` et plus bas vous devrez voir tous les champs avec leur valeur définis par défaut qui peuvent être modifié puis valider le tous avec `EXECUTE`
(pour vérifier que tout a bien fonctionné il suffit simplement de faire une nouvelle requête GET (ou get selon l'id pour éviter de chercher parmi plusieurs lignes) afin de voir si la nouvelle ligne s'est bien inseré)


# Requete PUT : 

Afin d'effectuer une requête PUT il faut clicker sur `PUT` -->  `TRY IT OUT`,  préciser l'id de la ligne que l'on veut modifier et modifier les champs justes en dessous puis faire `EXECUTE`

# REQUETE DELETE : 

Afin d'effectuer une requête DELETE il faut clicker sur `DELETE` -->  `TRY IT OUT`,  préciser l'id de la ligne que l'on veut supprimer puis faire `EXECUTE`

