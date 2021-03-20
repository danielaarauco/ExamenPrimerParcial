using System;
using System.Reflection;

namespace Parcial1_DanielaAraucoPadilla.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}