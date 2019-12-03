using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEditor;
namespace Puppet3D
{
	public class ColladaExporterExport : MonoBehaviour
	{
		public class COLLADA
		{
			public class material
			{
				[XmlAttribute("id")]
				public string ID;
				[XmlAttribute("name")]
				public string Name;

			}
			public class geometry
			{
				[XmlAttribute("id")]
				public string ID;
				[XmlAttribute("name")]
				public string Name;

				public class source
				{
					[XmlAttribute("id")]
					public string ID;
					public class floatarray
					{
						[XmlAttribute("id")]
						public string ID;
						[XmlAttribute("count")]
						public float count;

						public string FloatString;
					}
					public floatarray float_array = new floatarray();
				}
				public List<source> mesh = new List<source>();

			}
			public List<material> library_materials = new List<material>();
			public List<geometry> library_geometries = new List<geometry>();


			// Use this for initialization
			//[MenuItem("Puppet3D/export collada")]
			static public void ExportCollad()
			{
				SkinnedMeshRenderer smr = Selection.activeGameObject.GetComponent<SkinnedMeshRenderer>();
				ColladaExporter export = new ColladaExporter(("Assets/" + Selection.activeGameObject.name + ".dae"), true);
				export.AddGeometry(Selection.activeGameObject.name, smr.sharedMesh, smr);
				export.AddGeometryToScene(Selection.activeGameObject.name, Selection.activeGameObject.name);

				export.AddControllerToScene(smr.bones);


				export.Save();
				return;
				/*
				COLLADA collada = new COLLADA();
				material mat = new material();
				mat.ID = "lambert1";
				mat.Name = "lambert1";

				geometry geo = new geometry();
				geo.ID = "cube";
				geo.Name = "cube";
				geometry.source pos = new geometry.source();
				pos.float_array.FloatString = "0 0 0\n0 0 0";
				pos.float_array.ID = "cube-Position-array";
				pos.float_array.count = 2;
				geometry.source normal = new geometry.source();
				geometry.source uv0 = new geometry.source();

				geo.mesh.Add(pos);
				geo.mesh.Add(normal);
				geo.mesh.Add(uv0);

				collada.library_materials.Add(mat);
				collada.library_geometries.Add(geo);

				string path = Path.Combine(Application.persistentDataPath, "monsters.xml");
				Debug.Log(path);
				collada.Save(path);*/
			}

			public void Save(string path)
			{
				var serializer = new XmlSerializer(typeof(COLLADA));
				using (var stream = new FileStream(path, FileMode.Create))
				{
					serializer.Serialize(stream, this);
				}
			}

			public static COLLADA Load(string path)
			{
				var serializer = new XmlSerializer(typeof(COLLADA));
				using (var stream = new FileStream(path, FileMode.Open))
				{
					return serializer.Deserialize(stream) as COLLADA;
				}
			}

			//Loads the xml directly from the given string. Useful in combination with www.text.
			public static COLLADA LoadFromText(string text)
			{
				var serializer = new XmlSerializer(typeof(COLLADA));
				return serializer.Deserialize(new StringReader(text)) as COLLADA;
			}
		}
	}
}
