using Mono.Cecil;
using NetArchTest.Rules;

namespace CustomerREPRAPITests.Architecture
{
    public class OnlyOnePublicMethodInControllerRule : ICustomRule
    {
        public bool MeetsRule(TypeDefinition type)
        {
            return type.Methods.Count(x => x.IsPublic && !x.IsConstructor).Equals(1);
        }
    }
}
