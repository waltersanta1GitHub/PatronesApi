namespace PatronesApi.Dtos;
public class PlayerDto
    {        
        string Name { get; set; }
        string CharacterClass { get; set; }
        int HitPoints { get; set; }
        int ExperiencePoints { get; set; }
        int Level { get; set; }
        int Gold { get; set; }
    }