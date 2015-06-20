using BundleTransformer.Core.Transformers;
using System.Web.Optimization;

namespace nineHoles.Utils
{
	public class LessBundle : Bundle
	{
		public LessBundle(string virtualPath)
			: base(virtualPath)
		{
			this.Transforms.Add(new StyleTransformer());
		}
	}
}