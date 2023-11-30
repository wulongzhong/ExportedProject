using System;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	public class DemoConfigureScript : MonoBehaviour
	{
		private const string scriptTemplate = "// Important, make sure this script is assigned properly, or you will get null ref exceptions.\r\n    DigitalRuby.ThunderAndLightning.LightningBoltScript script = gameObject.GetComponent<DigitalRuby.ThunderAndLightning.LightningBoltScript>();\r\n    int count = {0};\r\n    float duration = {1}f;\r\n    float delay = 0.0f;\r\n    int seed = {2};\r\n    System.Random r = new System.Random(seed);\r\n    Vector3 start = new Vector3({3}f, {4}f, {5}f);\r\n    Vector3 end = new Vector3({6}f, {7}f, {8}f);\r\n    int generations = {9};\r\n    float chaosFactor = {10}f;\r\n    float trunkWidth = {11}f;\r\n    float intensity = {12}f;\r\n    float glowIntensity = {13}f;\r\n    float glowWidthMultiplier = {14}f;\r\n    float forkedness = {15}f;\r\n    float singleDuration = Mathf.Max(1.0f / 30.0f, (duration / (float)count));\r\n    float fadePercent = {16}f;\r\n    float growthMultiplier = {17}f;\r\n    System.Collections.Generic.List<LightningBoltParameters> paramList = new System.Collections.Generic.List<LightningBoltParameters>();\r\n    while (count-- > 0)\r\n    {{\r\n        DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters = new DigitalRuby.ThunderAndLightning.LightningBoltParameters\r\n        {{\r\n            Start = start,\r\n            End = end,\r\n            Generations = generations,\r\n            LifeTime = (count == 1 ? singleDuration : (singleDuration * (((float)r.NextDouble() * 0.4f) + 0.8f))),\r\n            Delay = delay,\r\n            ChaosFactor = chaosFactor,\r\n            ChaosFactorForks = chaosFactor,\r\n            TrunkWidth = trunkWidth,\r\n            GlowIntensity = glowIntensity,\r\n            GlowWidthMultiplier = glowWidthMultiplier,\r\n            Forkedness = forkedness,\r\n            Random = r,\r\n            FadePercent = fadePercent, // set to 0 to disable fade in / out\r\n            GrowthMultiplier = growthMultiplier\r\n        }};\r\n        paramList.Add(parameters);\r\n        delay += (singleDuration * (((float)r.NextDouble() * 0.8f) + 0.4f));\r\n    }}\r\n    script.CreateLightningBolts(paramList);\r\n";

		private int lastSeed;

		private Vector3 lastStart;

		private Vector3 lastEnd;

		public LightningBoltScript LightningBoltScript;

		public Slider GenerationsSlider;

		public Slider BoltCountSlider;

		public Slider DurationSlider;

		public Slider ChaosSlider;

		public Slider TrunkWidthSlider;

		public Slider ForkednessSlider;

		public Slider IntensitySlider;

		public Text IntensityValueLabel;

		public Slider GlowIntensitySlider;

		public Slider GlowWidthSlider;

		public Slider FadePercentSlider;

		public Slider GrowthMultiplierSlider;

		public Slider DistanceSlider;

		public Text GenerationsValueLabel;

		public Text BoltCountValueLabel;

		public Text DurationValueLabel;

		public Text ChaosValueLabel;

		public Text TrunkWidthValueLabel;

		public Text ForkednessValueLabel;

		public Text GlowIntensityValueLabel;

		public Text GlowWidthValueLabel;

		public Text FadePercentValueLabel;

		public Text GrowthMultiplierValueLabel;

		public Text DistanceValueLabel;

		public Text SeedLabel;

		public RawImage StartImage;

		public RawImage EndImage;

		public Button CopySeedButton;

		public InputField SeedInputField;

		public Text SpaceBarLabel;

		public Toggle OrthographicToggle;

		public void GenerationsSliderChanged(float value)
		{
		}

		public void BoltCountSliderChanged(float value)
		{
		}

		public void DurationSliderChanged(float value)
		{
		}

		public void LengthSliderValueChanged(float value)
		{
		}

		public void TrunkSliderValueChanged(float value)
		{
		}

		public void intensitySliderValueChanged(float value)
		{
		}

		public void GlowSliderValueChanged(float value)
		{
		}

		public void FadePercentValueChanged(float value)
		{
		}

		public void GrowthMultiplierValueChanged(float value)
		{
		}

		public void DistanceValueChanged(float value)
		{
		}

		public void StartLightningDrag()
		{
		}

		public void EndLightningDrag()
		{
		}

		public void CreateButtonClicked()
		{
		}

		public void OrthographicToggleClicked()
		{
		}

		public void CopyButtonClicked()
		{
		}

		public void ClearButtonClicked()
		{
		}

		private void UpdateUI()
		{
		}

		private void CallLightning()
		{
		}

		private void UpdateStatusLabel(TimeSpan time)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
