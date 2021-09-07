using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Singleton.Tests;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestService.Adam_is_unique();
            Console.WriteLine($"Test Adam_is_unique OK");
            TestService.Adam_is_unique_and_only_GetInstance_can_return_adam();
            Console.WriteLine($"Test Adam_is_unique_and_only_GetInstance_can_return_adam OK");
            TestService.Adam_is_unique_and_cannot_be_overriden();
            Console.WriteLine($"Test Adam_is_unique_and_cannot_be_overriden( OK");
            TestService.Adam_is_a_human();
            Console.WriteLine($"Test Adam_is_a_human OK");
            TestService.Adam_is_a_male();
            Console.WriteLine($"Test Adam_is_a_male OK");
            TestService.Eve_is_unique_and_created_from_a_rib_of_adam();
            Console.WriteLine($"Test Eve_is_unique_and_created_from_a_rib_of_adam OK");
            TestService.Eve_can_only_be_create_of_a_rib_of_adam();
            Console.WriteLine($"Test Eve_can_only_be_create_of_a_rib_of_adam OK");
            TestService.Eve_is_a_human();
            Console.WriteLine($"Test Eve_is_a_human OK");
            TestService.Eve_is_a_female();
            Console.WriteLine($"Test Eve_is_a_female OK");
            TestService.Reproduction_always_result_in_a_male_or_female();
            Console.WriteLine($"Test Reproduction_always_result_in_a_male_or_female OK");
            TestService.Humans_can_reproduce_when_there_is_a_name_a_mother_and_a_father();
            Console.WriteLine($"Test Humans_can_reproduce_when_there_is_a_name_a_mother_and_a_father OK");
            TestService.Father_and_mother_are_essential_for_reproduction();
            Console.WriteLine($"Test Father_and_mother_are_essential_for_reproduction OK");
        }
    }
}
