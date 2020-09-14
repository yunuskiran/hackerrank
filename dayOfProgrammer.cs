 static string dayOfProgrammer(int year) 
 {
      int day = 13;
      if (year == 1918)
          day = 26;
      if (year % 4 == 0 && (year < 1918 || year % 100 != 0 || (year % 400 == 0)))
          day--;

      return $"{day}.09.{year}";
 }
