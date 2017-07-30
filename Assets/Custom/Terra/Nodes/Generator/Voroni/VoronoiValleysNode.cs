﻿using Terra.CoherentNoise;
using System;
using Terra.CoherentNoise.Generation.Voronoi;
using Terra.GraphEditor;

namespace Terra.Nodes.Generation {
	[Serializable]
	[GraphContextMenuItem("Noise/Voroni", "Valleys")]
	public class VoronoiValleysNode: AbstractVoronoiNoiseNode {
		public VoronoiValleysNode(int id, Graph parent) : base(id, parent) { }

		public override Generator GetGenerator() {
			VoronoiValleys2D noise = new VoronoiValleys2D(12); //TODO: Implement static seed
			noise.Frequency = Frequency;
			noise.Period = (int)Period;

			return noise;
		}
	}
}
