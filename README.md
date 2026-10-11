# TF Stellar Mod Manager

> ⚠️ **Branche privée `tf` : version custom réservée à mes potes et moi.**
> Ce n'est pas la version officielle de Stellar Mod Manager. Pour la version officielle, voir [jollyname/StellarModManager](https://github.com/jollyname/StellarModManager).

Fork de [Stellar Mod Manager](https://github.com/jollyname/StellarModManager), le gestionnaire de mods pour **StellarDrive**.

## Différences avec la version officielle

- **Dépôts personnalisés** : *Paramètres → Dépôts personnalisés* permet d'ajouter d'autres listes de mods (`mods.json`).
- **Notre dépôt de mods préconfiguré** : [tidic84/StellarModRepository](https://github.com/tidic84/StellarModRepository) (nos mods et ceux de Romalaure) s'affiche avec les mods officiels, sans rien configurer.
- **Logiciel séparé** : s'appelle *TFStellarModManager*, s'installe à côté de la version officielle sans la remplacer, avec ses propres réglages.
- **Mises à jour** : l'app vérifie les [releases de ce fork](https://github.com/tidic84/StellarModManager/releases), pas celles de l'officiel.
- Thème **Midnight Slate** par défaut.

## Installation

1. Télécharger `TFStellarModManager_<version>_Setup.exe` dans la [dernière release](https://github.com/tidic84/StellarModManager/releases/latest).
2. Lancer l'installateur. Windows SmartScreen peut avertir car l'exe n'est pas signé : *Informations complémentaires → Exécuter quand même*.
3. Au premier lancement, choisir le dossier de StellarDrive. L'app peut installer MelonLoader automatiquement.

## Publier une nouvelle version (pour moi)

1. Augmenter `<Version>` dans `StellarModManager.csproj`.
2. Build :
   ```
   dotnet publish StellarModManager.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o App
   ```
   puis copier `License.txt`, `PostInfo.txt` et `Assets/icon.ico` dans `App/`, et supprimer `App/*.pdb`.
3. Installateur : `ISCC.exe /DMyAppVersion=<version> StellarModManager.iss` (Inno Setup 6) → `Output/`.
4. Release GitHub avec le tag `v<version>` (marquée *Latest*, pas pré-release) contenant le `..._Setup.exe`.

Les apps déjà installées proposent la mise à jour au lancement suivant.

## Licence

MIT, comme le projet d'origine.
