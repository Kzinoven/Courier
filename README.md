The Courier
===========

DIGM Senior Project by TL;DR Games
----------------------------------

GitHub Repository and Documentation by Dustin Otwell

Built in Unity3D 4 and Visual Studio 2012
Assets in Autodesk Maya and Pro Tools

Target Platform: PC

IMPORTANT INFORMATION BELOW:
----------------------------

Naming Conventions:
-------------------
Everything should be in camelCase, starting with a lowercase letter.

Author names should be first-name ONLY, all lowercase.

Dates will be in day/month/year format separated by underscores.
For instance: if the asset was saved on the 28th of October, 2013:
the name would include "28_oct_2013" in the filename.

Version numbers will have three digits with leading zeroes, preceded by a v.
Version numbers are ALWAYS LAST in the name.
THERE ARE NO FINAL VERSIONS.
IF THE WORD "FINAL" IS IN THE FILENAME I WILL DELETE IT.

That means that the first version of a file will end in "_v001.ext" and so on

Models:
Source files (.ma/.mb) should be named in this way:
modelName_author_date_version.ma

Files to be imported (.fbx/.obj) should be named in this way:
modelName_version.obj

Sounds:
Source files and project files should be named:
soundName[_loop]_author_date_version.ext

Import files should be named:
soundName[_loop]_version.ext

The optional brackets indicate which files are looping sounds and which are not.
If there are any other distinctions you feel that you need, please add them to this list.

Code and Scripts:
Code will be in .cs format for C# scripts.  All scripts follow the same naming convention:
CamelCase starting with an UPPERCASE letter.  The name of the script must match the name of the class defined.
NO SPACES, SPECIAL CHARACTERS OR UNDERSCORES.

For instance: "UnityClassName.cs"

Version information and changelogs will be recorded in header comments within the code files themselves.

Each script will start with:

/*
*  Class Name
*  Version v.ss.bb
*  
*  Definition of the class's function and purpose (may be multiple lines)
*  
*  Changelog, in reverse chronological order.  That means new changes go to the TOP.
*
*/

The changelog will be formatted like so:

Date: Author First Name:  General description of changes made.
	From version (old number, before you changed anything)v.ss.bb:
	-bulleted
	-list
	-of
	-changes
	Updated to (new version number)v.ss.bb.

Version numbers are recorded as:
	v = Version number, starting at 0.  
		Increments when subversion reaches 99.
	ss = Subversion number, starting at 00.  Increments:
		-when a new function is added
		-when a major change is made to the code
		-when an old function is removed
		-when build number reaches 99
	bb = Build number, starting at 00.  Increments:
		-when a new variable is added
		-when minor changes are made to the code
		-when you build/test the code
		-when adding documentation and comments

The skeleton version of the code will be 0, followed by the number of functions, and then the number of variables.
A default/empty MonoBehaviour script will be 0.02.000 (having only two subroutines)
