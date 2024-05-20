const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";
//------------------------------------
int openingPosition = input.IndexOf("<span>");
int closingPosition = input.IndexOf("</span>");

openingPosition += 6;

int length = closingPosition - openingPosition;

output = input;
output = output.Remove(0, "<div>".Length);

int position = output.IndexOf("</div>");
Console.WriteLine(position);

output = output.Remove(position, "</div>".Length);

output = output.Replace("&trade;", "&reg;");
//-------------------------------------
Console.WriteLine($"Quantity: {input.Substring(openingPosition, length)}");
Console.WriteLine($"Output: {output}");





