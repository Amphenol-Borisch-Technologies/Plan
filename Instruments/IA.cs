﻿using System;

namespace ABT.Test.Plan.UUT.Instruments {
    /// <summary>
    /// IA correlates TestExecutive.ConfigurationTestExec's canonical SCPI_VISA_InstrumentElement IDs to meaningful TestExecutor Customer UUT specific names, or aliases.
    /// <para>
    /// So, UUT power supplies, input stimuli & output signals might be meaningfully correlated to TestExecutive.ConfigurationTestExec's instruments as follows:
    ///     internal static class IA {
    ///         internal static readonly Alias P2V5      = new Alias("PS1");   // Single output Power Supply 1
    ///         internal static readonly Alias P3V3      = new Alias("PS2");   // Single output Power Supply 2
    ///         internal static readonly Alias P5V       = new Alias("PS3");   // Single output Power Supply 3
    ///         internal static readonly Alias P12V_N12V = new Alias("PS4ε5"); // Dual-output Power Supplies 4 & 5.
    ///         internal static readonly Alias VOUT      = new Alias("EL1");   // Electrical Load 1.
    ///         internal static readonly Alias MM        = new Alias("MM1");   // Multi-Meter 1.
    ///         internal static readonly Alias CLK       = new Alias("WG1");   // WaveGenerator 1.
    ///     }
    ///
    /// - Include only required/utilized SCPI VISA Instruments:
	/// - That is, if this TestExecutive.ConfigurationTestExec contains elements for 10 power supplies, but a TestExecutor program
	///   only requires & utilizes 2, simply don't alias the unused 8 in class IA.
	/// - This documents the minimum necessary SCPI VISA Instrument configuration for the TestExecutor's program.
	/// - Allows a TestExecutor program to be most easily ported to different Test Systems having different TestExecutive.ConfigurationTestExec configurations.
	/// 	- If Test System #1 with it's specific SCPI VISA Instruments dies suddenly, may need to run its TestExecutor programs on Test System #2
	/// 		with different SCPI VISA Instruments.
	/// 	- If all TestExecutor.cs files list only their necessary SCPI VISA Instruments, quite easy to determine which are
	/// 		compatible subsets of the Test Systems' TestExecutive.ConfigurationTestExec configurations.
	/// - This approach is similar to the Keysight i3070's Board config files:
	/// 	- i3070 Board config files specify only the subset of i3070 cards used by their test programs.
	/// 	- This makes porting a Keysight i3070 In-Circuit Test program to a differently configured i3070 as easy as possible, though not necessarily easy.    
    /// </para>
    /// </summary>
    internal static class IA {
        internal static readonly String PRI_BIAS = "PS1ε2";
        internal static readonly String SEAL     = "PS3";
        internal static readonly String MSO      = "MSO1";
        internal static readonly String MSMU     = "MSMU1";
        internal static readonly String MM       = "MM1";
        internal static readonly String WG       = "WG1ε2";
    }
}
