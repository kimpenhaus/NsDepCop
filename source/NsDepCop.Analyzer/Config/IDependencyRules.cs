﻿using System.Collections.Generic;

namespace Codartis.NsDepCop.Config
{
    /// <summary>
    /// Describes dependency rules.
    /// </summary>
    public interface IDependencyRules
    {
        /// <summary>
        /// True means that all child namespaces can depend on any of their parent namespaces without an explicit Allowed rule.
        /// True is in line with how C# type resolution works: it searches parent namespaces without an explicit using statement.
        /// False means that all dependencies must be explicitly allowed with a rule.
        /// False is the default for backward compatibility.
        /// </summary>
        bool ChildCanDependOnParentImplicitly { get; }
        bool ParentCanDependOnChildImplicitly { get; }

        /// <summary>
        /// Dictionary of allowed dependency rules. The key is a namespace dependency rule, 
        /// the value is a set of type names defined in the target namespace and visible for the source namespace(s).
        /// </summary>
        Dictionary<DependencyRule, TypeNameSet> AllowRules { get; }

        /// <summary>
        /// The set of disallowed dependency rules.
        /// </summary>
        HashSet<DependencyRule> DisallowRules { get; }

        /// <summary>
        /// Dictionary of visible types by target namespace. The key is the name of a namespace, 
        /// the value is a set of type names defined in the namespace and visible outside of the namespace.
        /// </summary>
        Dictionary<Domain, TypeNameSet> VisibleTypesByNamespace { get; }

        HashSet<DependencyRule> AllowedAssemblyRules { get; }

        HashSet<DependencyRule> DisallowedAssemblyRules { get; }
    }
}
