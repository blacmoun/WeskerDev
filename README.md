# StoryLife

## Description du Projet
StoryLife est un jeu développé en utilisant le langage de programmation C#. Ce jeu consiste à demander au joueur de faire des choix, ses actions auront un impacte sur le cours de l'histoire.

## Prérequis

- Langage de Programmation: C#
- Environnement de Développement: Visual Studio Enterprise 2022 Version 17.8.3
- Moteur de Base de donées: MySql80
- Support visuel pour la Base de donnée: HeidiSql / MySqlWorkbench 8.0

### Configuration

- Installer la dernière mise à jour de l'environnement Visual Studio 2022 v17.8.0 (Entreprise) depuis le site officiel.
- Installer l'installeur MySql (Windows (x86, 32-bit), MSI Installer) depuis le site officiel et choisir le téléchargement via webinstaller (2,1 Mb).
- Installer HeidiSql depuis le site officiel et ouvrer votre session et entrant vos identifiants que vous avez du configurer lors de l'installation MySql.
- Lancer le script de la base de donnée "base de donnée.sql" qui est dans le dossier doc pour pouvoir la créer.
- Créer un compte admin avec ses identifiants dans HeidiSql:
	nom : admin
	mot de passe : admin

	ce compte aura les droit pour faire des updates et des select.

## Déploiement

- Lancement d'un projet C# Library depuis l'environnement de VS 2022
- Créer depuis sa solution deux autres projets dont un projet de Test et un autre WindowsForm

### Environnement de développement

- Une fois le projet ouvert, aller dans l'onglet Tools, puis dans NuGet Package Manager et séléctionner Package Manager Console
- Tapez la commande "Install-Package MySQL.Data"

## Structure du Projet

- 🗃️Solution 'StoryLife' (3 of 3 projects)
- 	Solution Items
- 	🔒StoryLife
- 		▷ ᥫ Dependencies
		▷ 🔒 C# Choice.cs
		▷ 🔒 C# Frame.cs
		▷ 🔒 C# Game.cs
		▷ 🔒 C# Menu.cs
		▷ 🔒 C# Player.cs
		▷ 🔒 C# Scenario.cs
		▷ 🔒 C# Story.cs
- 	🔒TestStoryLife
- 		▷ ᥫ Dependencies
		    🔒 C# GlobalUsings.cs
		▷ 🔒 C# TestChoice.cs
		▷ 🔒 C# TestDbConnection.cs
		▷ 🔒 C# TestFrame.cs
		▷ 🔒 C# TestGame.cs
		▷ 🔒 C# TestMenu.cs
		▷ 🔒 C# TestPlayer.cs
		▷ 🔒 C# TestScenario.cs
		▷ 🔒 C# TestStory.cs
- 	🔒Undertale
- 		▷ ᥫ Dependencies
		▷ 🔒 📁 Properties
		▷ 🔒 📁 Resources
		▷ 🔒 📁 RJControl
		▷ 🔒 🔍 ArroundTheMarket.cs
		▷ 🔒 🔍 Choice_Dungeon.cs
		▷ 🔒 🔍 credit.cs
		   🔒 ⚙️ desktop.ini
		▷ 🔒 🔍 Frame_Bathroom.cs
		▷ 🔒 🔍 Frame_ContinueAlone.cs
		▷ 🔒 🔍 Frame_CryAroundTheFire.cs
		▷ 🔒 🔍 Frame_EntrenceMarket.cs
		▷ 🔒 🔍 Frame_hall.cs
		▷ 🔒 🔍 Frame_inFrontOfHouse.cs
		▷ 🔒 🔍 Frame InFrontOfTheDoor.cs
		▷ 🔒 🔍 Frame_kitchen.cs
		▷ 🔒 🔍 Frame_LivingRoom.cs
		▷ 🔒 🔍 Frame_TalkToGoatInDungeon.cs
		▷ 🔒 🔍 Frame_ToTheEndOfTheWay.cs
		▷ 🔒 🗃️ Game.cs
		▷ 🔒 🔍 Intro.cs
		▷ 🔒 🗂️ Launcher.resx
		▷ 🔒 🗃️ Loading.cs
		▷ 🔒  C# Program.cs
		▷ 🔒 🗃️ Settings.cs
		▷ 🔒 🗃️ Undertale.cs

## Contactez-nous

- Timothé Kobel           : timothe.kobel@eduvaud.ch
- Amin De Abreu Jdidi     : marc-antoine.aboud@eduvaud.ch
- Marc-Antoine Aboud      : amin.deabreu@eduvaud.ch
