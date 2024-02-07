﻿using System;


public enum Jobs
{
    MEDIC,
    PAINTER,
    ENGINEER,
    STUDENT,
    FARMER,
    LAWYER,
    MUSICIAN,
    SCIENTIST,
    SOLDIER,
    ARTISAN,
    VETERAN,
    TEACHER,
    PLUMBER,
    CHEMIST,
    COMPUTER_SCIENTIST,
    LIBRARIAN,
    ARCHITECT,
    UNEMPLOYED,
}

public enum Hobby
{
    BASKETBALL_PLAYER,
    FOOTBALL_PLAYER,
    BASEBALL_PLAYER,
    TENNIS_PLAYER,
    SWIMMER,
    GOLFER,
    BOXER,
    CYCLIST,
    RUNNER,
    GYMNAST,
    DANCER,
    CHESS_PLAYER,
    GAMER,
}

public enum Personalities
{
    ADVENTUROUS,
    SHY,
    CHARISMATIC,
    OPTIMISTIC,
    PESSIMISTIC,
    ALTRUISTIC,
    EGOTIST,
    ANGRY,
    CALM,
    REALIST,
    DREAMER,
    LAZY,
    HARD_WORKER,
    HUMBLE,
    INTELLIGENT,
    STUPID,
    COWARD,
    BRAVE,
    SENSITIVE,
    INSENSITIVE,
    SADISTIC,
    HONEST,
    LIAR,
    NAIVE,
}

public enum Status
{
    ORPHAN,
    EDUCATED,
    ANALPHABET,
    INJURED,
    DISABLED,
}

public enum RomanticStatus
{
    SINGLE,
    MARRIED,
    DIVORCED,
    WIDOW,
}

public enum LifeStyle
{
    VOYAGER,
    CITY_HABITANT,
    COUNTRY_HABITANT,
    EXCENTRIC,
    GAMER,
    ART_LOVER,
    CRIMINAL,
}

public enum Category
{
    JOB,
    STATUS,
    PERSONNALITY,
    LIFESTYLE,
}

[Flags]
public enum TraitTags
{
    RICH = 1 << 0,
    POOR = 1 << 1,
    SMART = 1 << 2,
    DISABLED = 1 << 3,
    DANGEROUS = 1 << 4,
    ARTISTIC = 1 << 5,
    STRANGE = 1 << 6,
    UNEDUCATED = 1 << 7,
    GOOD = 1 << 8,
    BAD = 1 << 9,
}

public static class EnumExtensions
{
    public static string Name(this Jobs job)
    {
        return job switch
        {
            Jobs.MEDIC => "Medic",
            Jobs.PAINTER => "Painter",
            Jobs.ENGINEER => "Engineer",
            Jobs.STUDENT => "Student",
            Jobs.FARMER => "Farmer",
            Jobs.LAWYER => "Lawyer",
            Jobs.MUSICIAN => "Musician",
            Jobs.SCIENTIST => "Scientist",
            Jobs.SOLDIER => "Soldier",
            Jobs.ARTISAN => "Artisan",
            Jobs.VETERAN => "Veteran",
            Jobs.TEACHER => "Teacher",
            Jobs.PLUMBER => "Plumber",
            Jobs.CHEMIST => "Chemist",
            Jobs.COMPUTER_SCIENTIST => "Computer scientist",
            Jobs.LIBRARIAN => "Librarian",
            Jobs.ARCHITECT => "Architect",
            Jobs.UNEMPLOYED => "Unemployed",
            _ => "Unknown"
        };
    }
    
    public static TraitTags Tags(this Jobs job)
    {
        return job switch
        {
            Jobs.MEDIC => TraitTags.SMART | TraitTags.RICH,
            Jobs.PAINTER => TraitTags.ARTISTIC | TraitTags.POOR,
            Jobs.ENGINEER => TraitTags.SMART | TraitTags.RICH,
            Jobs.STUDENT => TraitTags.SMART,
            Jobs.FARMER => TraitTags.POOR | TraitTags.UNEDUCATED,
            Jobs.LAWYER => TraitTags.SMART | TraitTags.RICH,
            Jobs.MUSICIAN => TraitTags.ARTISTIC | TraitTags.POOR,
            Jobs.SCIENTIST => TraitTags.SMART | TraitTags.RICH,
            Jobs.SOLDIER => TraitTags.DANGEROUS,
            Jobs.ARTISAN => TraitTags.ARTISTIC | TraitTags.POOR,
            Jobs.VETERAN => TraitTags.DANGEROUS,
            Jobs.TEACHER => TraitTags.SMART | TraitTags.RICH,
            Jobs.PLUMBER => TraitTags.POOR,
            Jobs.CHEMIST => TraitTags.SMART | TraitTags.RICH,
            Jobs.COMPUTER_SCIENTIST => TraitTags.SMART | TraitTags.RICH,
            Jobs.LIBRARIAN => TraitTags.SMART | TraitTags.RICH,
            Jobs.ARCHITECT => TraitTags.SMART | TraitTags.RICH,
            Jobs.UNEMPLOYED => TraitTags.POOR,
            _ => TraitTags.RICH
        };
    }

    public static string Name(this Hobby hobby)
    {
        return hobby switch
        {
            Hobby.BASKETBALL_PLAYER => "Basketball player",
            Hobby.FOOTBALL_PLAYER => "Football player",
            Hobby.BASEBALL_PLAYER => "Baseball player",
            Hobby.TENNIS_PLAYER => "Tennis player",
            Hobby.SWIMMER => "Swimmer",
            Hobby.GOLFER => "Golfer",
            Hobby.BOXER => "Boxer",
            Hobby.CYCLIST => "Cyclist",
            Hobby.RUNNER => "Runner",
            Hobby.GYMNAST => "Gymnast",
            Hobby.DANCER => "Dancer",
            Hobby.CHESS_PLAYER => "Chess player",
            Hobby.GAMER => "Gamer",
            _ => "Unknown"
        };
    }
    
    public static string Name(this Personalities personality)
    {
        return personality switch
        {
            Personalities.ADVENTUROUS => "Adventurous",
            Personalities.SHY => "Shy",
            Personalities.CHARISMATIC => "Charismatic",
            Personalities.OPTIMISTIC => "Optimistic",
            Personalities.PESSIMISTIC => "Pessimistic",
            Personalities.ALTRUISTIC => "Altruistic",
            Personalities.EGOTIST => "Egotist",
            Personalities.ANGRY => "Angry",
            Personalities.CALM => "Calm",
            Personalities.REALIST => "Realist",
            Personalities.DREAMER => "Dreamer",
            Personalities.LAZY => "Lazy",
            Personalities.HARD_WORKER => "Hard worker",
            Personalities.HUMBLE => "Humble",
            Personalities.INTELLIGENT => "Intelligent",
            Personalities.STUPID => "Stupid",
            Personalities.COWARD => "Coward",
            Personalities.BRAVE => "Brave",
            Personalities.SENSITIVE => "Sensitive",
            Personalities.INSENSITIVE => "Insensitive",
            Personalities.SADISTIC => "Sadistic",
            Personalities.HONEST => "Honest",
            Personalities.LIAR => "Liar",
            Personalities.NAIVE => "Naive",
            _ => "Unknown"
        };
    }
    
    public static TraitTags Tags(this Personalities personality)
    {
        return personality switch
        {
            Personalities.ADVENTUROUS => TraitTags.GOOD,
            Personalities.SHY => TraitTags.POOR,
            Personalities.CHARISMATIC => TraitTags.SMART,
            Personalities.OPTIMISTIC => TraitTags.GOOD,
            Personalities.PESSIMISTIC => TraitTags.BAD,
            Personalities.ALTRUISTIC => TraitTags.GOOD,
            Personalities.EGOTIST => TraitTags.BAD,
            Personalities.ANGRY => TraitTags.DANGEROUS,
            Personalities.CALM => TraitTags.GOOD,
            Personalities.REALIST => TraitTags.SMART,
            Personalities.DREAMER => TraitTags.GOOD,
            Personalities.LAZY => TraitTags.POOR,
            Personalities.HARD_WORKER => TraitTags.GOOD,
            Personalities.HUMBLE => TraitTags.GOOD,
            Personalities.INTELLIGENT => TraitTags.SMART,
            Personalities.STUPID => TraitTags.UNEDUCATED,
            Personalities.COWARD => TraitTags.BAD,
            Personalities.BRAVE => TraitTags.GOOD,
            Personalities.SENSITIVE => TraitTags.GOOD,
            Personalities.INSENSITIVE => TraitTags.BAD | TraitTags.DANGEROUS,
            Personalities.SADISTIC => TraitTags.BAD | TraitTags.DANGEROUS,
            Personalities.HONEST => TraitTags.GOOD,
            Personalities.LIAR => TraitTags.BAD,
            Personalities.NAIVE => TraitTags.UNEDUCATED,
            _ => TraitTags.GOOD
        };
    }

    public static string Name(this Status status)
    {
        return status switch
        {
            Status.ORPHAN => "Orphan",
            Status.EDUCATED => "Educated",
            Status.ANALPHABET => "An-alphabet",
            Status.INJURED => "Injured",
            Status.DISABLED => "Disabled",
            _ => "Unknown"
        };
    }
    
    public static TraitTags Tags(this Status status)
    {
        return status switch
        {
            Status.ORPHAN => TraitTags.POOR,
            Status.EDUCATED => TraitTags.SMART,
            Status.ANALPHABET => TraitTags.UNEDUCATED,
            Status.INJURED => TraitTags.DISABLED,
            Status.DISABLED => TraitTags.DISABLED,
            _ => TraitTags.RICH
        };
    }
    
    public static string Name(this RomanticStatus romanticStatus)
    {
        return romanticStatus switch
        {
            RomanticStatus.SINGLE => "Single",
            RomanticStatus.MARRIED => "Married",
            RomanticStatus.DIVORCED => "Divorced",
            RomanticStatus.WIDOW => "Widow",
            _ => "Unknown"
        };
    }
    
    public static string Name(this LifeStyle lifeStyle)
    {
        return lifeStyle switch
        {
            LifeStyle.VOYAGER => "Voyager",
            LifeStyle.CITY_HABITANT => "City inhabitant",
            LifeStyle.COUNTRY_HABITANT => "Country inhabitant",
            LifeStyle.EXCENTRIC => "Eccentric",
            LifeStyle.GAMER => "Gamer",
            LifeStyle.ART_LOVER => "Art lover",
            LifeStyle.CRIMINAL => "Criminal",
            _ => "Unknown"
        };
    }
}