public class FileIOChanges : SingletonInit<FileIOChanges>
{
	public delegate void OnDataChangedDelegate();

	private event OnDataChangedDelegate onDataChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public void OnChange(OnDataChangedDelegate dataChangeDelegate)
	{
	}

	public override void Init()
	{
	}

	private void OnMessage(string message)
	{
	}

	private void ReloadModels()
	{
	}

	public FileIOChanges()
	{
        //((SingletonInit<>)(object)this)._002Ector();
    }
}
