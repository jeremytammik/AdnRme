# AdnRme

![Revit API](https://img.shields.io/badge/Revit%20API-2020-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgray.svg)
![.NET](https://img.shields.io/badge/.NET-4.7-blue.svg)
[![License](http://img.shields.io/:license-mit-blue.svg)](http://opensource.org/licenses/MIT)

Revit MEP Sample Application for Revit MEP HVAC and electrical

Demonstrate use of the Revit API for MEP specific tasks.

Keywords: Revit API C# .NET add-in.

## HVAC

Use of the generic Revit API for HVAC specific tasks, using only standard Revit element properties and parameters:

- Determine air terminals for each space.
- Assign flow to the air terminals depending on the space's calculated supply air flow.
- Change size of diffuser based on flow.
- Populate the value of the 'CFM per SF' variable on all spaces.
- Determine unhosted elements.
- Reset demo.

## Electrical

Use of the MEP specific API to traverse an electrical system and display its hierarchy in a tree view.


## Documentation

- [The ADN MEP Sample AdnRme for Revit MEP 2013](http://thebuildingcoder.typepad.com/blog/2012/05/the-adn-mep-sample-adnrme-for-revit-mep-2013.html)
- [The ADN Sample AdnRme for Revit MEP 2014](http://thebuildingcoder.typepad.com/blog/2013/06/the-adn-sample-adnrme-for-revit-mep-2014.html)
- [AdnRme Migrated to Revit MEP 2015 on GitHub](http://thebuildingcoder.typepad.com/blog/2014/06/adnrme-migrated-to-revit-mep-2015-on-github.html)


## Author

Jeremy Tammik,
[The Building Coder](http://thebuildingcoder.typepad.com),
[ADN](http://www.autodesk.com/adn)
[Open](http://www.autodesk.com/adnopen),
[Autodesk Inc.](http://www.autodesk.com)


## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT).
Please see the [LICENSE](LICENSE) file for full details.
