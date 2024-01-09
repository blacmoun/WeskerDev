# StoryLife

## Description du Projet
StoryLife est un jeu développé en utilisant le langage de programmation C#. Ce jeu consiste à demander au joueur de faire des choix, ses actions auront un impacte sur le cours de l'histoire.

## Prérequis

- Langage de Programmation: C#
- Environnement de Développement: Visual Studio Enterprise 2022 Version 17.7.6
- Moteur de Base de donées: MySql80
- Support visuel pour la Base de donnée: HeidiSql / MySqlWorkbench 8.0

### Configuration

- Installer la dernière mise à jour de l'environnement Visual Studio 2022 v17.8.0 (Entreprise) depuis le site officiel.
- Installer l'installeur MySql (Windows (x86, 32-bit), MSI Installer) depuis le site officiel et choisir le téléchargement via webinstaller (2,1 Mb).
- Installer HeidiSql depuis le site officiel et ouvrer votre session et entrant vos identifiants que vous avez du configurer lors de l'installation MySql.
- Lancer le script de la base de donnée qui est dans le dossier doc pour pouvoir la créer.
- Créer un compte admin avec ses identifiants dans HeidiSql:
nom : admin
mot de passe : admin
ce compte aura les droit pour faire des updates et des select.

## Deployment

- Lancement d'un projet C# Library depuis l'environnement de VS 2022
- Créer depuis sa solution deux autres projets dont un projet de Test et un autre WindowsForm

### On dev environment

- Une fois le projet ouvert, aller dans l'onglet Tools, puis dans NuGet Package Manager et séléctionner Package Manager Console
- Tapez la commande "Install-Package MySQL.Data"

## Directory structure

* ├───doc
* ├───Solution Items
      ├───README.md
├───StoryLife                                       //classes and packages
│   ├───Choice.cs
│   ├───Frame.cs
│   ├───Game.cs
│   ├───Menu.cs
│   ├───Player.cs
│   ├───Story.cs
│       └───Dependencies
└───TestShopping                                    //test classes
│   ├───GlobalUsings.cs
│   ├───TestChoice.cs
│   ├───TestFrame.cs
│   ├───TestGame.cs
│   ├───TestMenu.cs
│   ├───TestPlayer.cs
│   ├───TestStory.cs
│       └───Dependencies
└───Undertale                                      //form app and design
│   ├───Program.cs
│   ├───Undertale.cs
│       └───Dependencies

## Contact

Timothé Kobel           : timothe.kobel@eduvaud.ch
Amin De Abreu Jdidi     : amin.deabreu@eduvaud.ch
Marc-Antoine Aboud      : marc-antoine.aboud@eduvaud.ch
