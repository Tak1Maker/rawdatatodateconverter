using System.Globalization;

var listOfDatesOfNumbers = new List<string>() { "206" , "606", "2060", "307"};


for(int i = 0; i < listOfDatesOfNumbers.Count; i++)
{
    if (listOfDatesOfNumbers[i].Length < 4)
        listOfDatesOfNumbers[i] = "0" + listOfDatesOfNumbers[i];
        
    Console.WriteLine(DateTime.ParseExact(listOfDatesOfNumbers[i], "ddMM", CultureInfo.InvariantCulture, DateTimeStyles.None));
}

