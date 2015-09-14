using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CW_File_Viewer_2._0
{

    public partial class Form1 : Form
    {
               // fpath = folderbroser.ShowDialog;
        string fname;
        string last;
        string infile;
        string backup;
        string filepath;
        string[] fpos=new string[1000];
        int nowp = 0;
        int maxn;
        public Form1()
        {
            InitializeComponent();
        }

        private void filev_SelectedIndexChanged(object sender, EventArgs e)
        {
               // MessageBox.Show(path, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (this.filev.SelectedItems.Count > 0)
            {
                fname = this.filev.SelectedItems[0].Text;
                fpos[nowp+1] = fpos[nowp] + '\\' + fname;
                //MessageBox.Show(path, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //folderbroser.SelectedPath = folderbroser.SelectedPath;
                //实例化DirectoryInfo对象

                last = Path.GetExtension(fpos[nowp+1]);

                this.sfpath.Text = fpos[nowp+1];
                //获取指定目录下的所有子目录及文件类型
                if (Directory.Exists(fpos[nowp+1]))
                {
                    ++nowp;
                    maxn = maxn>nowp?maxn:nowp;
                    //MessageBox.Show(fpos[nowp], "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    filev.Items.Clear();
                    DirectoryInfo dinfo = new DirectoryInfo(fpos[nowp]);
                    FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                    foreach (FileSystemInfo fsinfo in fsinfos)
                    {
                        if (fsinfo is DirectoryInfo)    //判断是否文件夹
                        {
                            //使用获取的文件夹名称实例化DirectoryInfo对象
                            DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                            //为ListView控件添加文件夹信息
                            filev.Items.Add(dirinfo.Name);
                            filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                        }
                        else
                        {
                            //使用获取的文件名称实例化FileInfo对象
                            FileInfo finfo = new FileInfo(fsinfo.FullName);
                            //为ListView控件添加文件信息
                            filev.Items.Add(finfo.Name);
                            filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.FullName);
                        }
                    }
                }
                else
                {
                    //last;
                    if (last == ".lrc" || last == ".txt" || last == ".LRC" || last == ".TXT")
                    {
                        if (last == ".lrc" || last == ".LRC")
                        {
                            //lrcv.Text = System.IO.File.ReadAllText(path);
                            StreamReader fileread = new StreamReader(fpos[nowp + 1]);//StreamReader sr = new StreamReader("TestFile.txt",Encoding.GetEncoding("GB2312"))
                            //StreamReader fileread = new StreamReader(path, Encoding.Default);
                            //StreamReader fileread = new StreamReader(path, Encoding.UTF8);
                            //StreamReader fileread = new StreamReader(path, Encoding.GetEncoding("gb2312"));
                            infile = fileread.ReadToEnd();
                            lrcv.Text = infile;
                            backup = infile;
                            filepath = fpos[nowp + 1];
                            fileread.Close();
                            //MessageBox.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        else if (last == ".txt" || last == ".TXT")
                        {
                            //lrcv.Text = System.IO.File.ReadAllText(path);
                            //StreamReader fileread = new StreamReader(fpos[nowp + 1]);
                            StreamReader fileread = new StreamReader(fpos[nowp + 1], Encoding.GetEncoding("GB2312"));
                            //StreamReader fileread = new StreamReader(path, Encoding.Default);
                            //StreamReader fileread = new StreamReader(path, Encoding.UTF8);
                            //StreamReader fileread = new StreamReader(path, Encoding.GetEncoding("gb2312"));
                            infile = fileread.ReadToEnd();
                            lrcv.Text = infile;
                            backup = infile;
                            filepath = fpos[nowp + 1];
                            fileread.Close();
                            //MessageBox.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                    }
                    if (last == ".mp3")
                    {
                        this.player.URL = fpos[nowp+1];
                    }

                }
            }
        }
        private void viewfile_Click(object sender, EventArgs e)
        {
            if (folderbroser.ShowDialog() == DialogResult.OK)
            {
                filev.Items.Clear();
                folderbroser.SelectedPath = folderbroser.SelectedPath;
                fpos[++nowp] = folderbroser.SelectedPath;
                maxn = maxn > nowp ? maxn : nowp;
                sfpath.Text = fpos[nowp];
                //实例化DirectoryInfo对象
                DirectoryInfo dinfo = new DirectoryInfo(fpos[nowp]);
                //获取指定目录下的所有子目录及文件类型
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    if (fsinfo is DirectoryInfo)    //判断是否文件夹
                    {
                        //使用获取的文件夹名称实例化DirectoryInfo对象
                        DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                        //为ListView控件添加文件夹信息
                        filev.Items.Add(dirinfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add("");
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.CreationTime.ToShortDateString());
                    }
                    else
                    {
                        //使用获取的文件名称实例化FileInfo对象
                        FileInfo finfo = new FileInfo(fsinfo.FullName);
                        //为ListView控件添加文件信息
                        filev.Items.Add(finfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.Length.ToString());
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.CreationTime.ToShortDateString());
                    }
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void lrcv_TextChanged(object sender, EventArgs e)
        {
            infile = lrcv.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filepath = "Null";
            //this.lrcv.Text = System.IO.File.ReadAllText("C:\\Users\\david\\Desktop\\superbaga.lrc");
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (nowp > 1)
            {
                --nowp;
                sfpath.Text = fpos[nowp];
                //实例化DirectoryInfo对象
                filev.Items.Clear();
                DirectoryInfo dinfo = new DirectoryInfo(fpos[nowp]);
                //获取指定目录下的所有子目录及文件类型
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    if (fsinfo is DirectoryInfo)    //判断是否文件夹
                    {
                        //使用获取的文件夹名称实例化DirectoryInfo对象
                        DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                        //为ListView控件添加文件夹信息
                        filev.Items.Add(dirinfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add("");
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.CreationTime.ToShortDateString());
                    }
                    else
                    {
                        //使用获取的文件名称实例化FileInfo对象
                        FileInfo finfo = new FileInfo(fsinfo.FullName);
                        //为ListView控件添加文件信息
                        filev.Items.Add(finfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.Length.ToString());
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.CreationTime.ToShortDateString());
                    }
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (nowp < maxn)
            {
                ++nowp;
                sfpath.Text = fpos[nowp];
                //实例化DirectoryInfo对象
                filev.Items.Clear();
                DirectoryInfo dinfo = new DirectoryInfo(fpos[nowp]);
                //获取指定目录下的所有子目录及文件类型
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    if (fsinfo is DirectoryInfo)    //判断是否文件夹
                    {
                        //使用获取的文件夹名称实例化DirectoryInfo对象
                        DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                        //为ListView控件添加文件夹信息
                        filev.Items.Add(dirinfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add("");
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.CreationTime.ToShortDateString());
                    }
                    else
                    {
                        //使用获取的文件名称实例化FileInfo对象
                        FileInfo finfo = new FileInfo(fsinfo.FullName);
                        //为ListView控件添加文件信息
                        filev.Items.Add(finfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.Length.ToString());
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.CreationTime.ToShortDateString());
                    }
                }
            }
        }

        private void write_Click(object sender, EventArgs e)
        {;
            /*
            FileStream clear = File.Create(filepath);
            clear.Close();
            FileInfo files = new FileInfo(filepath);
            StreamWriter save = files.CreateText();
            save.Write(infile);
            save.Close();
             */
            if (filepath != "Null")
                File.WriteAllText(filepath, infile);
        }

        private void recover_Click(object sender, EventArgs e)
        {
            infile = backup;
            lrcv.Text = infile;
        }
    }
}
/*
StreamReader sr = new StreamReader("TestFile.txt")//StreamReader sr = new StreamReader("TestFile.txt",Encoding.GetEncoding("GB2312"))
///GBK
String line;
while ((line = sr.ReadLine()) != null)
{
   textBox1 .Text +=ii.ToString ()+" -"+line.ToString()+"\r\n";

}
加入引用：System.IO
StreamReader objReader = new StreamReader("c:\\test.txt");
     System.IO 命名空间中的对象，尤其是 System.IO.StreamReader 类。

\r\n一般一起用,用来表示键盘上的回车键.也可只用\n.\t表示键盘上的“TAB
*/