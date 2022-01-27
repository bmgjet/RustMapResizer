<h2># RustMapResizer a simple tool to change the size setting on map files.</h2>
<p>Run RustMapResizer.exe from the managed folder in rustedit or server files.<br />* C:\Program Files (x86)\RustEdit\RustEdit_Data\Managed<br />* C:\rust\RustServerFiles\RustDedicated_Data\Managed<br />It needs to run here since it depends on Rust.World.dll and Rust.Data.dll files.<br /><br /><span style="text-decoration: underline;"><strong>How to use:</strong></span><br />Enter the new size you want in the text input.<br />Click Convert, Select the map to change to this new size.<br />A new map file with .mod appended onto its file name will be created.<br />You can open and continue to edit this is rustedit.<br /><br />To run a map on a server with non stantard size you will have to edit the server size setting using a plugin and this hook to adjust it <br><br>private void OnTerrainCreate(TerrainGenerator _terrain) { global::World.Size = 150; ConVar.Server.worldsize = (int)150; }
