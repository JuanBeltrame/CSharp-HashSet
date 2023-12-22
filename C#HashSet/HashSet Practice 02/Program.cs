//-----------Programa Principal-----------

//-----------------------------------------------------------------------------
//-----------Primer Ejemplo-----------
HashSet<string> hobbies = new HashSet<string>();
hobbies.Add("Football");
hobbies.Add("Tennis");
hobbies.Add("Golf");
hobbies.Add("Hiking");
hobbies.Add("Tennis");

List<string> hobbiesList01 = new List<string>();
hobbiesList01.Add("Footbal");
hobbiesList01.Add("Tennis");
hobbiesList01.Add("Golf");
hobbiesList01.Add("Hiking");
hobbiesList01.Add("Tennis");

string[] hobbiesArray = new string[5];
hobbiesArray[0] = "Footbal";
hobbiesArray[1] = "Tennis";
hobbiesArray[2] = "Golf";
hobbiesArray[3] = "Hiking";
hobbiesArray[4] = "Tennis";

//-----------------------------------------------------------------------------
//-----------Segundo Ejemplo-----------
List<string> hobbiesList02 = new List<string>();
hobbiesList02.Add("Footbal");
hobbiesList02.Add("Tennis");
hobbiesList02.Add("Golf");
hobbiesList02.Add("Hiking");
hobbiesList02.Add("Tennis");

HashSet<string> uniqueHobbies = new HashSet<string>(hobbiesList02);

//-----------Use of methods-----------
uniqueHobbies.Contains("Golf");

//-----------------------------------------------------------------------------
//-----------Tercer Ejemplo-----------
HashSet<string> hobbiesA = new HashSet<string>();
hobbiesA.Add("Footbal");
hobbiesA.Add("Tennis");
hobbiesA.Add("Golf");


HashSet<string> hobbiesB = new HashSet<string>();
hobbiesB.Add("Hiking");
hobbiesB.Add("Golf");

//-----------Use of methods-----------
hobbiesA.UnionWith(hobbiesB);
hobbiesA.IntersectWith(hobbiesB);

