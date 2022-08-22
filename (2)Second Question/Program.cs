int currentTimeSec = 11111, currentHour, currentMinut;

currentHour = currentTimeSec/3600;
currentMinut = (currentTimeSec - (currentHour*3600))/60;

Console.WriteLine($"Current time: {currentHour}h : {currentMinut}min .");