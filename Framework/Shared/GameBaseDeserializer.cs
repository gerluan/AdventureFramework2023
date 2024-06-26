/*

using Framework.Slides.JsonClasses;
using JsonUtilities;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Framework.Game;

// This is just the json deserialization part of GameBase
// Put it in a separate file to make it easier to read
public partial class GameBase
{
	// [Inject]
	// HttpClient Http {get; set; } = null!;

	[Inject]
	JsonUtility JsonUtility { get; set; } = null!;

	private async Task<Dictionary<string, JsonSlide>> FetchSlidesAsync(string url)
	{
		// assign return value from GetFromJsonAsync to slides if it is not null, otherwise throw an exception
		// var slides = await Http.GetFromJsonAsync<Dictionary<string, JsonSlide>>(url) ?? throw new Exception("Slides is null");
		var slides = await JsonUtility.LoadFromJsonAsync<Dictionary<string, JsonSlide>>(url);
		return slides;
	}

	[Obsolete("Outdated, need to update")]
	private static void VerifySlides(Dictionary<string, JsonSlide> slides)
	{
		// idk, check every value to make sure it's not null
		// if you want no buttons/action, just set Buttons/Actions to an empty list
		// NOTE: This is just a null check, it doesn't check if the values are valid
		// which could result in runtime errors
		slides.Keys.ToList().ForEach(key =>
		{
			var slide = slides[key];
			if (slide.Image == null)
			{
				throw new Exception($"Slide {key} has a null image");
			}
			if (slide.Buttons == null)
			{
				throw new Exception($"Slide {key} has a null buttons");
			}
			slide.Buttons.Keys.ToList().ForEach(buttonKey =>
			{
				var button = slide.Buttons[buttonKey];
				// outdated, since Id is no longer included in the object
				// if (button.Id == null)
				// {
				// 	throw new Exception($"Slide {key} has a button with a null id");
				// }
				if (button.Points == null && button.Image == null)
				{
					throw new Exception($"Slide {key} has a button with a null points and null image");
				}
				if (button.Actions == null)
				{
					throw new Exception($"Slide {key} has a button with a null actions");
				}
			});
		});
	}

	// TODO: Make this actually useful
	public async Task<Dictionary<string, JsonSlide>> GetSlides(string url)
	{
		// var slides = await FetchSlidesAsync(url);
		// try
		// {
		// 	// VerifySlides(slides);
		// 	return slides;
		// }
		// catch (Exception e)
		// {
		// 	Console.WriteLine(e);
		// 	throw;
		// }
		return await FetchSlidesAsync(url);
	}

	// doesn't verify slides, is faster (probably) but could result in unexpected behavior
	public async Task<Dictionary<string, JsonSlide>> GetSlidesUnsafe(string url)
	{
		return await FetchSlidesAsync(url);
	}
}

*/