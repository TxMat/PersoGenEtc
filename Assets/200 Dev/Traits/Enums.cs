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
    EDUCATED = 1 << 2,
    DISABLED = 1 << 3,
    DANGEROUS = 1 << 4,
    ARTISTIC = 1 << 5,
    STRANGE = 1 << 6,
    DUMB = 1 << 7,
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
    
    public static TraitTags[] Tags(this Jobs job)
    {
        return job switch
        {
            Jobs.MEDIC => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.PAINTER => new TraitTags[] { TraitTags.ARTISTIC, TraitTags.POOR },
            Jobs.ENGINEER => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.STUDENT => new TraitTags[] { TraitTags.EDUCATED },
            Jobs.FARMER => new TraitTags[] { TraitTags.POOR },
            Jobs.LAWYER => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.MUSICIAN => new TraitTags[] { TraitTags.ARTISTIC, TraitTags.POOR },
            Jobs.SCIENTIST => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.SOLDIER => new TraitTags[] { TraitTags.DANGEROUS },
            Jobs.ARTISAN => new TraitTags[] { TraitTags.ARTISTIC, TraitTags.POOR },
            Jobs.VETERAN => new TraitTags[] { TraitTags.DANGEROUS },
            Jobs.TEACHER => new TraitTags[] { TraitTags.EDUCATED },
            Jobs.PLUMBER => new TraitTags[] { TraitTags.POOR },
            Jobs.CHEMIST => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.COMPUTER_SCIENTIST => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.LIBRARIAN => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.ARCHITECT => new TraitTags[] { TraitTags.EDUCATED, TraitTags.RICH },
            Jobs.UNEMPLOYED => new TraitTags[] { TraitTags.POOR },
            _ => new TraitTags[] { }
        };
    }

    public static string aaa(this LifeStyle lifeStyle)
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