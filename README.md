# RadaeePDF OCX

The application is a fast and small PDF viewer.

It relies on **RadaeePDF SDK** (https://www.radaeepdf.com) rendering engine wrapped in an OCX object running on Windows 32bit.

## Project structure

The project is available with C# sources and includes the dynamic library only in the binary form.

## Dependencies

To open and build the project you shall use MS VisualStudio 2017 or next version. The resulting project may run on any version of Windows from XP to current Windows 11.

## Setup and run

Register the OCX in your system opening a shell console as Administrator and executing `regsvr32 /s RDPDF.32.dll` from the folder `publish` of the repository.

If not available, copy `cmaps.dat` and `umaps.dat` in the same folder of `RDPDF.32.dll`.

Open the **PDFReaderOCX** project with VisualStudio and set the proper .NET framework's version: the default one is .NET 4.7.2.

## Use and limitation

You can use the included OCX in your projects and derive the user interface and code from the included C#.

You are allowed to rewrite the original user interface in any development language that is capable to reference an OCX object and it's classes. 

Use the OCX in your projects for free. 

To support our work, reference https://www.radaeepdf.com as author of the PDF reader engine.

## License

The entire project is available through Apache2 license.
