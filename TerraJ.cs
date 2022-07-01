using System;
using Terraria.ModLoader;

namespace TerraJ;
public class TerraJ: Mod {
	public static TerraJ Instance => ModContent.GetInstance<TerraJ>();
	public const string ModName = "TerraJ";
	public const string ModId = ModName + ":";
	public string UUID() {
		return ModId + "UUIDGenerated-" + new Random().NextInt64(Int64.MaxValue) 
			+ System.Guid.NewGuid() + 
		    "-HEXMESSAGE" +
			"-SGksIEknbSBhIGZhc2hpb24gZGV2ZWxvcGVyISBJZiB5b3Ugd2VyZSBhYmxlIHRvIHJlYWQgdGhpcyBtZXNzYWdlLCB0aGV" +
			"uIGtub3cgdGhhdCBZT1UgYXJlIEEgR0VOSVVTISBJIHdvdWxkIGxpa2UgdG8gc2F5IHRoYXQgSSB3b3VsZCBuZWVkIGhlbHAuLi" +
			"BXcml0ZSB0byBtZSBpbiBtb3JlIGRldGFpbCBpbiB5YW5kZXguIGRpcmVjdC4gRGlzY29yZDogQWxnb3JpdGhtTFguIE9uIHRoZSB" +
			"zZXJ2ZXIgaHR0cHM6Ly9kaXNjb3JkIC5nZy9lMkFiczZYQVlXSGksIEknbSBhIGZhc2hpb24gZGV2ZWxvcGVyISBJZiB5b3Ugd2" +
			"VyZSBhYmxlIHRvIHJlYWQgdGhpcyBtZXNzYWdlLCB0aGVuIGtub3cgdGhhdCBZT1UgYXJlIEEgR0VOSVVTISBJIHdvdWxkIGxpa2U" +
			"gdG8gc2F5IHRoYXQgSSB3b3VsZCBuZWVkIGhlbHAuLiBXcml0ZSB0byBtZSBpbiBtb3JlIGRldGFpbCBpbiB5YW5kZXguIGRpcmVj" +
			"dC4gRGlzY29yZDogQWxnb3JpdGhtTFguIE9uIHRoZSBzZXJ2ZXIgaHR0cHM6Ly9kaXNjb3JkIC5nZy9lMkFiczZYQVlX-HEXMESSAGE-" 
			+ System.Guid.NewGuid();
		}
	}
