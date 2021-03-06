using System;

namespace UnityEngine.XR.ARSubsystems
{
    /// <summary>
    /// Encapsulates the parameters for creating a new <see cref="XREnvironmentProbeSubsystemDescriptor"/>.
    /// </summary>
    public struct XREnvironmentProbeSubsystemCinfo : IEquatable<XREnvironmentProbeSubsystemCinfo>
    {
        /// <summary>
        /// Specifies an identifier for the provider implementation of the subsystem.
        /// </summary>
        /// <value>
        /// The identifier for the provider implementation of the subsystem.
        /// </value>
        public string id { get; set; }

        /// <summary>
        /// Specifies the provider implementation type to use for instantiation.
        /// </summary>
        /// <value>
        /// Specifies the provider implementation type to use for instantiation.
        /// </value>
        public Type implementationType { get; set; }

        /// <summary>
        /// Whether the implementation supports manual placement of environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if manual placement of environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsManualPlacement { get; set; }

        /// <summary>
        /// Whether the implementation supports removal of manually-placed environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if removal of manually-placed environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsRemovalOfManual { get; set; }

        /// <summary>
        /// Whether the implementation supports automatic placement of environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if automatic placement of environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsAutomaticPlacement { get; set; }

        /// <summary>
        /// Whether the implementation supports removal of automatically-placed environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if removal of automatically-placed environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsRemovalOfAutomatic { get; set; }

        /// <summary>
        /// Whether the implementation supports generation of environment textures.
        /// </summary>
        /// <value>
        /// <c>true</c> if the generation of environment textures is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsEnvironmentTexture { get; set; }

        /// <summary>
        /// Whether the implementation supports generation of HDR environment textures.
        /// </summary>
        /// <value>
        /// <c>true</c> if the generation of HDR environment textures is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsEnvironmentTextureHDR { get; set; }

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="other">The other <see cref="XREnvironmentProbeSubsystemCinfo"/> to compare against.</param>
        /// <returns>`True` if every field in <paramref name="other"/> is equal to this <see cref="XREnvironmentProbeSubsystemCinfo"/>, otherwise false.</returns>
        public bool Equals(XREnvironmentProbeSubsystemCinfo other)
        {
            return ReferenceEquals(id, other.id)
                   && ReferenceEquals(implementationType, other.implementationType)
                   && supportsManualPlacement.Equals(other.supportsManualPlacement)
                   && supportsRemovalOfManual.Equals(other.supportsRemovalOfManual)
                   && supportsAutomaticPlacement.Equals(other.supportsAutomaticPlacement)
                   && supportsRemovalOfAutomatic.Equals(other.supportsRemovalOfAutomatic)
                   && supportsEnvironmentTexture.Equals(other.supportsEnvironmentTexture)
                   && supportsEnvironmentTextureHDR.Equals(other.supportsEnvironmentTextureHDR);
        }

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="obj">The `object` to compare against.</param>
        /// <returns>`True` if <paramref name="obj"/> is of type <see cref="XREnvironmentProbeSubsystemCinfo"/> and
        /// <see cref="Equals(XREnvironmentProbeSubsystemCinfo)"/> also returns `true`; otherwise `false`.</returns>
        public override bool Equals(System.Object obj)
        {
            return ((obj is XREnvironmentProbeSubsystemCinfo) && Equals((XREnvironmentProbeSubsystemCinfo)obj));
        }

        /// <summary>
        /// Tests for equality. Same as <see cref="Equals(XREnvironmentProbeSubsystemCinfo)"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the comparison.</param>
        /// <param name="rhs">The right-hand side of the comparison.</param>
        /// <returns>`True` if <paramref name="lhs"/> is equal to <paramref name="rhs"/>, otherwise `false`.</returns>
        public static bool operator ==(XREnvironmentProbeSubsystemCinfo lhs, XREnvironmentProbeSubsystemCinfo rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Tests for inequality. Same as `!`<see cref="Equals(XREnvironmentProbeSubsystemCinfo)"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the comparison.</param>
        /// <param name="rhs">The right-hand side of the comparison.</param>
        /// <returns>`True` if <paramref name="lhs"/> is not equal to <paramref name="rhs"/>, otherwise `false`.</returns>
        public static bool operator !=(XREnvironmentProbeSubsystemCinfo lhs, XREnvironmentProbeSubsystemCinfo rhs)
        {
            return !(lhs == rhs);
        }

        /// <summary>
        /// Generates a hash suitable for use with containers like `HashSet` and `Dictionary`.
        /// </summary>
        /// <returns>A hash code generated from this object's fields.</returns>
        public override int GetHashCode()
        {
            int hashCode = 486187739;
            unchecked
            {
                hashCode = (hashCode * 486187739) + HashCode.ReferenceHash(id);
                hashCode = (hashCode * 486187739) + HashCode.ReferenceHash(implementationType);
                hashCode = (hashCode * 486187739) + supportsManualPlacement.GetHashCode();
                hashCode = (hashCode * 486187739) + supportsRemovalOfManual.GetHashCode();
                hashCode = (hashCode * 486187739) + supportsAutomaticPlacement.GetHashCode();
                hashCode = (hashCode * 486187739) + supportsRemovalOfAutomatic.GetHashCode();
                hashCode = (hashCode * 486187739) + supportsEnvironmentTexture.GetHashCode();
                hashCode = (hashCode * 486187739) + supportsEnvironmentTextureHDR.GetHashCode();
            }
            return hashCode;
        }
    }

    /// <summary>
    /// Specifies a functionality description that may be registered for each implementation that provides the
    /// <see cref="XREnvironmentProbeSubsystem"/> interface.
    /// </summary>
    public class XREnvironmentProbeSubsystemDescriptor : SubsystemDescriptor<XREnvironmentProbeSubsystem>
    {
        /// <summary>
        /// Constructs a <c>XREnvironmentProbeSubsystemDescriptor</c> based on the given parameters.
        /// </summary>
        /// <param name='environmentProbeSubsystemCinfo'>The parameters required to initialize the descriptor.</param>
        XREnvironmentProbeSubsystemDescriptor(XREnvironmentProbeSubsystemCinfo environmentProbeSubsystemCinfo)
        {
            id = environmentProbeSubsystemCinfo.id;
            subsystemImplementationType = environmentProbeSubsystemCinfo.implementationType;
            supportsManualPlacement = environmentProbeSubsystemCinfo.supportsManualPlacement;
            supportsRemovalOfManual = environmentProbeSubsystemCinfo.supportsRemovalOfManual;
            supportsAutomaticPlacement = environmentProbeSubsystemCinfo.supportsAutomaticPlacement;
            supportsRemovalOfAutomatic = environmentProbeSubsystemCinfo.supportsRemovalOfAutomatic;
            supportsEnvironmentTexture = environmentProbeSubsystemCinfo.supportsEnvironmentTexture;
            supportsEnvironmentTextureHDR = environmentProbeSubsystemCinfo.supportsEnvironmentTextureHDR;
        }

        /// <summary>
        /// Whether the implementation supports manual placement of environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if manual placement of environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsManualPlacement { get; private set; }

        /// <summary>
        /// Whether the implementation supports removal of manually-placed environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if removal of manually-placed environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsRemovalOfManual { get; private set; }

        /// <summary>
        /// Whether the implementation supports automatic placement of environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if automatic placement of environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsAutomaticPlacement { get; private set; }

        /// <summary>
        /// Whether the implementation supports removal of automatically-placed environment probes.
        /// </summary>
        /// <value>
        /// <c>true</c> if removal of automatically-placed environment probes is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsRemovalOfAutomatic { get; private set; }

        /// <summary>
        /// Whether the implementation supports generation of environment textures.
        /// </summary>
        /// <value>
        /// <c>true</c> if the generation of environment textures is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsEnvironmentTexture { get; private set; }

        /// <summary>
        /// Whether the implementation supports generation of HDR environment textures.
        /// </summary>
        /// <value>
        /// <c>true</c> if the generation of HDR environment textures is supported. Otherwise, <c>false</c>.
        /// </value>
        public bool supportsEnvironmentTextureHDR { get; private set; }

        /// <summary>
        /// Creates a <c>XREnvironmentProbeSubsystemDescriptor</c> based on the given parameters validating that the
        /// <c>id</c> and <c>implentationType</c> properties are specified.
        /// </summary>
        /// <param name='environmentProbeSubsystemCinfo'>The parameters required to initialize the descriptor.</param>
        /// <returns>
        /// The created <c>XREnvironmentProbeSubsystemDescriptor</c>.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when the values specified in the
        /// <paramref name="environmentProbeSubsystemCinfo"/> parameter are invalid. Typically, this will occur
        /// <list type="bullet">
        /// <item>
        /// <description>if <see cref="XREnvironmentProbeSubsystemCinfo.id"/> is <c>null</c> or empty</description>
        /// </item>
        /// <item>
        /// <description>if <see cref="XREnvironmentProbeSubsystemCinfo.implementationType"/> is <c>null</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>if <see cref="XREnvironmentProbeSubsystemCinfo.implementationType"/> does not derive from the
        /// <c>XREnvironmentProbeSubsystem</c> class
        /// </description>
        /// </item>
        /// </list>
        /// </exception>
        internal static XREnvironmentProbeSubsystemDescriptor Create(XREnvironmentProbeSubsystemCinfo environmentProbeSubsystemCinfo)
        {
            if (String.IsNullOrEmpty(environmentProbeSubsystemCinfo.id))
            {
                throw new ArgumentException("Cannot create environment probe subsystem descriptor because id is invalid",
                                            "environmentProbeSubsystemCinfo");
            }

            if ((environmentProbeSubsystemCinfo.implementationType == null)
                || !environmentProbeSubsystemCinfo.implementationType.IsSubclassOf(typeof(XREnvironmentProbeSubsystem)))
            {
                throw new ArgumentException("Cannot create environment probe subsystem descriptor because implementationType is invalid",
                                            "environmentProbeSubsystemCinfo");
            }

            return new XREnvironmentProbeSubsystemDescriptor(environmentProbeSubsystemCinfo);
        }
    }
}
