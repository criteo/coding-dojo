using svgSdk;

var svgCreator = new SvgCreator(width: 150, height: 200);
//svgCreator.AddRect(/* ??? */);
svgCreator.WriteToFile("myFile.svg");