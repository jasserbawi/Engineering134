﻿using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            
            else if (date.Month - birthDate.Month > 0)
            {
                var ageDate = date.Year - birthDate.Year;
                return Convert.ToInt32(ageDate);
            }
            else
            {
                var ageDate = date.Year - (birthDate.Year+1);
                return Convert.ToInt32(ageDate);
            }
        }

        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            string month = date.ToString("MMMM");
            return month;
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            if (suit == Suit.CLUBS)
            {
                return "And the seventh rule is if this is your first night at fight club, you have to fight.";
            }
            else if (suit == Suit.DIAMONDS)
            {
                return "Diamonds are a girls best friend";
            }
            else if (suit == Suit.HEARTS)
            {
                return "You've broken my heart";
            }
            else
            {
                return "Bucket and spade";
            }
        }
    }
}
