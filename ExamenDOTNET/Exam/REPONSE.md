1 : 

La différence entre .NET et .NET core est que .NET core est open source et cross plateform

ASP.NET Framework est un framework open-source et cross plateform INTRODUIT PAR .NET CORE, qui permet d'unifier les api et web api, intégré des framework client side comme Angular, héberger des application avec docker, apache 

2 : 

Les deux composant d'une api asp.net core sont les controllers et les models qui interagissent entre eux avec les attributs

les models sont en quelque sorte les tables de notre base de données, on y définit les champs
les controlleurs permettent de définir les route de l'api et les methode GET SET PUT DELETE


3 : 

Le routage s'effectue en indiquant le chemin de la route dans le controller de celle-ci avant la déclaration la class du controller 

exemple : 

[Route("api/v{version:apiVersion}/cities")]
    public class CitiesController : ControllerBase
    {

Ceci est la route pour accéder a cities et l'endpoint de celle-ci qui retourne les villes.


4 : 

Ceci permet de comprendre de qu'elle type de requête on parle et ce qu'il faut retourner, si c'est une requete [HttpGet] alors on sait qu'il faut retourner des réponse et si c'est une requête [HttpPost] alors on sait qu'il faut insérer des données dans la base de données si c'est une requête [HttpPut] alors on sait qu'il faut modifier des données dans la base de données et si c'est une requete [HttpDelete] alors on sait qu'il faut supprimer des données dans la base de données


5 :

On peut par exemple dans le models préciser qu'elle type de données, on veut (si c'est un entier, un string...) préciser si le champ peut être nul ou non avec un "?" A coter du type du champ (ex : public string? Description { get; set; } ) ou avec le [Required(ErrorMessage = "You should provide a name value.")] (ici, il y a même un message d'erreur si le point d'entrée n'est pas du bon type) la longueur maximale avec [MaxLength(50)] 

exemple : 

 public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }



6 :

Cette application est une API .NET 6 (ASP NET CORE 6) qui semble être destiner pour un site qui répertorie des villes et leur point d'intérets, au niveau du code on y vois 4 contrôler, 2 entities et 4 models qui sont les DTO (Data Transfer Object) des entities et plus précisément le premier est juste l'entities city, le deuxieme cities mais sans les point d'intéret, le troisième sert a inserer un nouveau point d'intéret et le dernier a mettre a jour un point d'intéret.

Ensuite, il y a le dossier profile qui sert a "mapper" (correspondre) les entities avec les dto et dedans ce fichier, il y en a un pour city et l'autre pour les points d'intérêt.


Afin d'avoir un aperçu des fonctionnalités d'une API .NET on peut utiliser swagger afin de pouvoir faire des requêtes depuis notre navigateur ou alors PostMan qui peut être une extension Vscode ou un exécutable (qui fait la même chose)

7 : 

L'application ne se build pas et le terminal me donne une erreur dans le CitiesControllers a la ligne 84 et il précisé que 'Le type 'CitiesController' définit déjà un membre appelé 'GetCity' avec les mêmes types de paramètres quand on regarde le code on vois que GetCity existe déjà un peu plus haut et que le code a été dupliqué.

Pour corriger l'erreur, il suffit simplement de supprimer ou de commenter de la ligne 76 a 102 (tout le code dupliqué) et a re build et on voit qu'il n'y a plus d'erreur.

8 : 

Dans le fichier Program.cs il y a AddSecurityRequirement qui ajoute de la sécurité a l'API et qui nécessite une clé afin de faire une requête ce n'est pas forcement une erreur, c'est juste que l'API est sécuriser et que je n'ai pas la clé pour y accéder