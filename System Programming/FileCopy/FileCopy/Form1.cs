namespace FileCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyFile(string source, string destination)
        {
            if (File.Exists(source))
            {
                if (!Path.Exists(destination) && !Path.HasExtension(destination))
                    Directory.CreateDirectory(destination);
                try
                {
                    using (var sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
                    {
                        if (!Path.HasExtension(destination))
                            destination = $@"{destination}\{Path.GetFileNameWithoutExtension(source)}Copy{Path.GetExtension(source)}";

                        if (Path.GetExtension(source) == Path.GetExtension(destination))
                        {
                            using (var destinationStream = new FileStream(destination, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                var len = 2000;
                                var bytes = new byte[len];
                                var totalBytes = 0;
                                do
                                {
                                    len = sourceStream.Read(bytes, 0, len);
                                    destinationStream.Write(bytes, 0, len);
                                    totalBytes += len;
                                    //Console.WriteLine(totalBytes);
                                    Thread.Sleep(100);

                                } while (0 < len);
                            }
                            MessageBox.Show("File copied");
                        }
                        else
                        {
                            MessageBox.Show("Choose correct file");
                            // ex.Message log
                           
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong");
                    // ex.Message log
                }

            }
            else
            {
                MessageBox.Show("File not found");
               
            }

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Thread thread = new(() => { CopyFile(label1.Text, label2.Text); });
            thread.Start();
            

        }

        private void BtnSoruce_Click(object sender, EventArgs e)
        {
            openFileSource.ShowDialog();
            label1.Text = openFileSource.FileName;
        }

        private void BtnDest_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label2.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
