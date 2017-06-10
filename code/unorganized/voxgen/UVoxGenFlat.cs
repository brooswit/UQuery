using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UVoxGenFlat : UVoxelGenerator {
  private float height;
  public UVoxGenFlat(float height) {
    this.height = height;
  }

  public override void GenerateAt (UData voxelData, int x, int y, int z) {
    if (y > this.height) { voxelData.Set("fill", 0f); }
    else { voxelData.Set("fill", 1f); }
  }
}
