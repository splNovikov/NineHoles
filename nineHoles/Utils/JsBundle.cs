using BundleTransformer.Core.Transformers;
using System.Web.Optimization;

namespace nineHoles.Utils
{
	public class JsBundle : Bundle
	{

		public JsBundle(string virtualPath)
			: base(virtualPath)
		{
			this.Transforms.Add(new ScriptTransformer());
		}

	}
}
