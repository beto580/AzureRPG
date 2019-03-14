namespace Rpg
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs.Host;
    using Microsoft.Extensions.Logging;
    using System.Text;

    public class HttpTrigger
    {
        public static IActionResult Run(HttpRequest req)
        {
            var characterName = req.Query["name"];

            return characterName != string.Empty
                ? (ActionResult)new OkObjectResult(CreateCharacter(characterName))
                : new BadRequestObjectResult("Please enter your character name through the query string");
        }

        public static string CreateCharacter(string characterName)
        {
            Character mainCharacter = new Character(characterName);
            var builder = new StringBuilder();

            builder.AppendLine($"Welcome {mainCharacter.Name}, these are your stats: ");
            builder.AppendLine($"LVL: {mainCharacter.Level}");
            builder.AppendLine($"XP: {mainCharacter.CurrentExperience}/{mainCharacter.NextLevelExperience}");
            builder.AppendLine($"HP: {mainCharacter.CurrentHealthPoints}/{mainCharacter.MaxHealthPoints}");

            return builder.ToString();
        }
    }
}