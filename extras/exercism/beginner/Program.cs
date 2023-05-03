using beginner.models.Lasagna;

Lasagna lasgna = new Lasagna();
Console.WriteLine(lasgna.ExpectedMinutesInOven());
Console.WriteLine(lasgna.RemainingMinutes(30));
Console.WriteLine(lasgna.PreparationTimeInMinutes(2));
Console.WriteLine(lasgna.ElapsedTimeInMinutes(3, 20));
