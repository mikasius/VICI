# VICI #

VICI stands for `Vocal Interface for Computer Interaction`.  While the name is a play off of Viki from the movie _I, Robot_, it is really based on the project [Eva][1] by [Casey Chestnut][2].

## Requirements ##

VICI is built on .NET 4.  All required third-party files are included in the source tree.

### Command line build ###
No additional installations are required to build from the command line.  Modification of `build.cmd` may be necessariy for pointing to `msbuild.exe` if the revision of the .NET framework is different.

### Visual Studio build ###
VICI makes use of [WiX][3] 3.5 to build the installer.  Installing the MSI will add the necessary project templates to your system to build further.

## To Build ##
To build the project, from the root of the source folder run the following command:

    build

To build everything (artifacts, tests, installer, reports), run the following command:

    build /t:build_all


   [1]: http://www.brains-n-brawn.com/eva
   [2]: http://www.brains-n-brawn.com
   [3]: http://wix.codeplex.com/