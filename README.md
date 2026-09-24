# SuperviseurPresse

Application de démonstration de la formation DVS-CRA : supervision d'une presse hydraulique.

> **Projet pédagogique.** Il reproduit volontairement des situations courantes sur une application industrielle ancienne, pour les exercices sur Git, GitHub Actions et le Cyber Resilience Act. Certaines pratiques y sont **mauvaises exprès**, et signalées comme telles dans le code. Ne pas reprendre en production.

## Pile technique

- VB.NET, Windows Forms, .NET Framework 4.8
- Projet au format « ancien » (non SDK), dépendances NuGet dans `packages.config`
- Une DLL de fournisseur versionnée dans `lib/`, sans paquet NuGet
- Tests en VB.NET avec MSTest

## Compiler et tester

Avec Visual Studio 2022 : ouvrir `SuperviseurPresse.sln`, puis Générer, puis Test, Exécuter tous les tests.

En ligne de commande, depuis une « Invite de commandes développeur » :

```powershell
msbuild SuperviseurPresse.sln -t:restore -p:RestorePackagesConfig=true
msbuild SuperviseurPresse.sln -p:Configuration=Release
vstest.console tests\SuperviseurPresse.Tests\bin\Release\SuperviseurPresse.Tests.dll
```

**Piège :** `dotnet build` ne restaure pas `packages.config`. Sur un poste où les paquets ont déjà été restaurés par Visual Studio, il compile ; sur un poste ou un runner neuf, il échoue (`BC30451 : 'JsonConvert' n'est pas déclaré`). Utilisez `msbuild -t:restore -p:RestorePackagesConfig=true`.

## Situations reproduites pour la formation

| Situation | Où |
|---|---|
| Mot de passe écrit en dur, contrôle désactivé en Debug | `src/SuperviseurPresse/Securite/ControleAcces.vb` |
| DLL de fournisseur versionnée, invisible pour Dependabot et pour le SBOM | `lib/Fournisseur.Automate.dll` |
| Version de l'exécutable (1.0.0.0) différente de celle du CHANGELOG (2.3.1) | `My Project/AssemblyInfo.vb` |
| Dépendances dans `packages.config` | `src/SuperviseurPresse/packages.config` |
| Code généré par le concepteur, source de conflits | `FrmPrincipal.Designer.vb` |
| Logique métier sortie du formulaire, donc testable | `Metier/CalculPression.vb` |

## Composants tiers

| Composant | Version | Origine | Licence |
|---|---|---|---|
| Newtonsoft.Json | 13.0.3 | NuGet | MIT |
| Fournisseur.Automate | 3.1.7 | DLL fournie par le fabricant de l'automate (fictif) | propriétaire |
