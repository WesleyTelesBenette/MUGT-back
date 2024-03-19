using mugt_back.Dtos;

namespace mugt_back.Services;

public static class GenerateService
{
    private static Random random = new();

    public static GenerateUserResponseDto Start(GenerateUserRequestDto objectDto)
    {
        GenerateUserResponseDto generateUser = new();

        if (objectDto.Name)                 generateUser.Name = GenerateName();
        if (objectDto.UserName)             generateUser.UserName = GenerateUserName();
        if (objectDto.Age)                  generateUser.Age = GenerateAge();
        if (objectDto.Birthday)             generateUser.Birthday = GenerateBirthday();
        if (objectDto.Ethnicity)            generateUser.Ethnicity = GenerateEthnicity();
        if (objectDto.Nationality)          generateUser.Nationality = GenerateNationality();
        if (objectDto.Email)                generateUser.Email = GenerateEmail();
        if (objectDto.Telephone)            generateUser.Telephone = GenerateTelephone();
        if (objectDto.PhysicalDisability)   generateUser.PhysicalDisability = GeneratePhysicalDisability();
        if (objectDto.VoterId)              generateUser.VoterId = GenerateVoterId();
        if (objectDto.DriversLicense)       generateUser.DriversLicense = GenerateDriversLicense();
        if (objectDto.MaritalStatus)        generateUser.MaritalStatus = GenerateMaritalStatus();
        if (objectDto.ProfileImage)         generateUser.ProfileImage = GenerateProfileImage();
        if (objectDto.EnemScore)            generateUser.EnemScore = GenerateEnemScore();
        if (objectDto.AcademicEducation)    generateUser.AcademicEducation = GenerateAcademicEducation();
        if (objectDto.Profession)           generateUser.Profession = GenerateProfession();
        if (objectDto.PsychologicalProblem) generateUser.PsychologicalProblem = GeneratePsychologicalProblem();
        if (objectDto.BasicPassword)        generateUser.BasicPassword = GenerateBasicPassword();
        if (objectDto.StrongPassword)       generateUser.StrongPassword = GenerateStrongPassword();
        if (objectDto.CPF)                  generateUser.CPF = GenerateCPF();
        if (objectDto.RG)                   generateUser.RG = GenerateRG();
        if (objectDto.Gender)               generateUser.Gender = GenerateGender();
        if (objectDto.FavouriteColour)      generateUser.FavouriteColour = GenerateFavouriteColour();
        if (objectDto.FavoriteFood)         generateUser.FavoriteFood = GenerateFavoriteFood();
        if (objectDto.Weight)               generateUser.Weight = GenerateWeight();
        if (objectDto.Height)               generateUser.Height = GenerateHeight();

        return generateUser;
    }

    private static string GenerateName()
    {
        return "";
    }

    private static string GenerateUserName()
    {
        return "";
    }

    private static int GenerateAge()
    {
        return random.Next(0, 101);
    }

    private static string GenerateBirthday()
    {
        return "";
    }

    private static string GenerateEthnicity()
    {
        return "";
    }

    private static string GenerateNationality()
    {
        return "";
    }

    private static string GenerateEmail()
    {
        return "";
    }

    private static string GenerateTelephone()
    {
        string returnVar = $"+55 {random.Next(11, 98)} 9";

        for (int c = 0; c < 8; c++)
        {
            int r = random.Next(0, 10);

            if ((c == 0) && (r == 0)) r = random.Next(1, 10);
            if (c == 4) returnVar += "-";

            returnVar += r.ToString();
        }

        return returnVar;
    }

    private static string GeneratePhysicalDisability()
    {
        return "";
    }

    private static string GenerateVoterId()
    {
        return "";
    }

    private static string GenerateDriversLicense()
    {
        return "";
    }

    private static string GenerateMaritalStatus()
    {
        return "";
    }
    private static string GenerateProfileImage()
    {
        return "";
    }
    private static string GenerateEnemScore()
    {
        return "";
    }
    private static string GenerateAcademicEducation()
    {
        return "";
    }
    private static string GenerateProfession()
    {
        return "";
    }

    private static string GeneratePsychologicalProblem()
    {
        return "";
    }

    private static string GenerateBasicPassword()
    {
        return "";
    }

    private static string GenerateStrongPassword()
    {
        return "";
    }

    private static string GenerateCPF()
    {
        return "";
    }

    private static string GenerateRG()
    {
        return "";
    }

    private static string GenerateGender()
    {
        return "";
    }

    private static string GenerateFavouriteColour()
    {
        return "";
    }

    private static string GenerateFavoriteFood()
    {
        return "";
    }

    private static double GenerateWeight()
    {
        return random.NextDouble() * (120 - 20) + 20;
    }

    private static double GenerateHeight()
    {
        return random.NextDouble() * (2.0 - 1.0) + 1.0;
    }
}
