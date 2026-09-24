Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

<Assembly: AssemblyTitle("SuperviseurPresse")>
<Assembly: AssemblyDescription("Supervision d'une presse hydraulique (projet de démonstration DVS-CRA)")>
<Assembly: AssemblyCompany("LaPolaris Formation")>
<Assembly: AssemblyProduct("SuperviseurPresse")>
<Assembly: AssemblyCopyright("Exemple de formation")>
<Assembly: ComVisible(False)>
<Assembly: Guid("2d0a3f37-6c1e-4b1b-9a53-1f6f0c5e8b21")>

' Le projet de tests accède aux classes Friend sans qu'on les rende publiques
<Assembly: InternalsVisibleTo("SuperviseurPresse.Tests")>

' Version jamais mise à jour : le CHANGELOG annonce 2.3.1, l'exécutable dit 1.0.0.0
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
