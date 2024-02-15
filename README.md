# MonoGame.SingleProject.Sdk [Work in Progress]

This project provides single project support for MonoGame. Similar
to how the Maui single project system works. Rather than having
multiple "Head" projects for each platform, you can now have
just one project.

Now rather than having all the platform specific code in different
projects it is all contained in the `Platforms/<Platform>` folder.
For example if you have `Android` specific code you can place this
in `Platforms/Android`. You can also place platform specific resources
in these folders as well.

[] Add Resizetier for application Icons.
[] Move to a NuGet Rather than a Custom SDK
