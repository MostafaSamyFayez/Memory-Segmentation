using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Segmentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable memorytable = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            MemoryDrawTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            memorytable.Columns.Add("Start Address");
            memorytable.Columns.Add("Block");
            MemoryDrawTable.DataSource = memorytable;
        }

        private void MemoryDrawTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /* ----Memory List Description----
         * 
         * (Address,  Size,  Name, Type)
         * 1- segment(1,2,3,4,5)
         * 2-old process(-1,-2,-3)
         * 3-hole(0)
         * Address: is the starting address of the block(segment)
         * Type: 0  Hole
         * Type: 1,2,3,4,.... process numbers
         * Type: -1,-2,-3,....Old Process numbers
         * 
         * Name: Segment Name(Code, Data, ...)
         * For Old Process or Hole Segment Name = 'x'
         */
        int memory_size;
        int procees_number;
        int n_segments;
        int old_process_number = 1;
        //method 0 for first fit , 1 for best fit , 2 for worst fit
        int method = 0;

        // segment(name, size)
        List<KeyValuePair<string, int>> Segments = new List<KeyValuePair<string, int>>();

        List<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>> Memory = new List<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>>();
        List<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>> MemoryBackup = new List<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>>();


        private void ResetButton_Click(object sender, EventArgs e)
        {
            Memory.Clear();
            Segments.Clear();
            MemoryBackup.Clear();
            old_process_number = 1;
            method = 0;
            memorytable.Clear();

        }
        private void InsertMemorySizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                memory_size = Convert.ToInt32(MemorySizeCell.Text);
                MemorySizeCell.Clear();
                if (!MemorySizeLegal(memory_size))
                {
                    MessageBox.Show("Input Size less than max hole Address !");
                    MemorySizeCell.Clear();
                    return;
                }
                GenerateOldProcesses();
                CombineHoles();
                CombineHoles();
            }
            catch
            {
                MessageBox.Show("You Should Input number");
                MemorySizeCell.Clear();
            }
        }

        private void InsertHoleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hole_address = Convert.ToInt32(HoleAddressCell.Text);
                int hole_size = Convert.ToInt32(HoleSizeCell.Text);
                if((hole_address<0)||(hole_size<0))
                {
                    MessageBox.Show("Input should be Only Numbers >= 0");
                    return;
                }
                AddBlockToMem(hole_address, hole_size, "x", 0);
                HoleAddressCell.Clear();
                HoleSizeCell.Clear();
            }
            catch
            {
                MessageBox.Show("Input should be Only Numbers > 0");
                HoleAddressCell.Clear();
                HoleSizeCell.Clear();
                return;
            }
        }

        private void InsertProceesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert process data and clear segment list to get new segments in the list

                Segments.Clear();
                procees_number = Convert.ToInt32(ProcessNumberCell.Text);
                n_segments = Convert.ToInt32(NOfSegmentsCell.Text);
                if ((n_segments > 0)&&(procees_number>0))
                {
                    if (FirstFit.Checked) method = 0;
                    if (BestFit.Checked) method = 1;
                    if (WorstFit.Checked) method = 2;
                }
                else
                {
                    MessageBox.Show("Input should be Only Numbers > 0");
                    ProcessNumberCell.Clear();
                    NOfSegmentsCell.Clear();
                    return;
                }
                ProcessNumberCell.Clear();
                NOfSegmentsCell.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Input should be Only Numbers > 0");
                ProcessNumberCell.Clear();
                NOfSegmentsCell.Clear();
                return;
            }
        }

        private void InsertSegmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Add Inserted segment to list of segments for this process
                string segment_name = SegmentNameCell.Text;
                int segment_size = Convert.ToInt32(SegmentSizeCell.Text);
                if (segment_size > 0)
                {
                    KeyValuePair<string, int> oneSegment = new KeyValuePair<string, int>(segment_name, segment_size);

                    if (n_segments > 0) { Segments.Add(oneSegment); }
                    n_segments--;
                    //Last segment inserted
                    if (n_segments == 0)
                    {
                        if (!IsFit())
                        {
                            MessageBox.Show("Process Does Not Fit Memory!");
                            ProcessNumberCell.Clear();
                            NOfSegmentsCell.Clear();
                        }
                        else
                        {
                            //allocated successfully
                            Memory.Clear();
                            Memory = MemoryBackup.ToList();
                            MessageBox.Show("Process Added Successfully!");
                            ProcessNumberCell.Clear();
                            NOfSegmentsCell.Clear();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input should be Only Numbers > 0");
                    ProcessNumberCell.Clear();
                    NOfSegmentsCell.Clear();
                    return;
                }
                SegmentNameCell.Clear();
                SegmentSizeCell.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Input should be Only Numbers > 0");
            }
            //This Line Only For Debug
            Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
        }

        private void DeallocateButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                procees_number = Convert.ToInt32(DeallocateCell.Text);
                if (procees_number > 0)
                {
                    if (IsOldProcessCheck.Checked) procees_number = (-procees_number);
                    DeallocateProcess(procees_number);
                }
                else
                {
                    MessageBox.Show("Input should be Only Numbers > 0");
                }
                DeallocateCell.Clear();
            }
            catch
            {
                MessageBox.Show("Input should be Only Numbers > 0");
                DeallocateCell.Clear();
                return;
            }
        }

        private void DrawMemoryButton_Click(object sender, EventArgs e)
        {
            Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
            memorytable.Clear();
            int hole_n = 0;
            for (int i = 0; i < Memory.Count; i++)
            {
                int address=Memory[i].Key.Key;
                string name=Memory[i].Value.Key;
                int type = Memory[i].Value.Value;
                string BlockData="";
                if (type == 0) { BlockData = "Hole" + hole_n.ToString()+ "                    "; hole_n++; }
                if (type < 0) { BlockData = "OldProcess: P" + (-type).ToString()+ "                    "; }
                if (type > 0) { BlockData = "P" + type.ToString() + ": " + name+"                    "; }
                memorytable.Rows.Add(address,BlockData);
            }
            memorytable.Rows.Add(memory_size-1, " ");
        }
         private void AddBlockToMem(int address,int size, string name, int type)
        {
            KeyValuePair<int, int> kvp1 = new KeyValuePair<int, int>(address, size);
            KeyValuePair<string, int> kvp2 = new KeyValuePair<string, int>(name, type);
            KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>> block = new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>(kvp1, kvp2);
            Memory.Add(block);
        }
        private void AddBlockToMemBackup(int address, int size, string name, int type)
        {
            KeyValuePair<int, int> kvp1 = new KeyValuePair<int, int>(address, size);
            KeyValuePair<string, int> kvp2 = new KeyValuePair<string, int>(name, type);
            KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>> block = new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>(kvp1, kvp2);
            MemoryBackup.Add(block);
        }
        private void GenerateOldProcesses()
        {
            //Sort in Addresses
            Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));

            for(int i=0;i<Memory.Count;i++)
            {
                int current_address = Memory[i].Key.Key;
                int current_size = Memory[i].Key.Value;
                int nxt_address;

                if (i == (Memory.Count - 1)) nxt_address = memory_size;
                else nxt_address = Memory[i + 1].Key.Key;
                //old process exist --> this handel corner case if its the first block address is not zero
                if((i==0)&&(current_address!=0))
                {
                    int block_address = 0;
                    int block_size = current_address;
                    AddBlockToMem(block_address, block_size, "x", -old_process_number);
                    old_process_number++;
                }
                //old process exist this
                if ((current_address+current_size)<nxt_address)
                {
                    int block_address = current_address + current_size;
                    int block_size=nxt_address-block_address;
                    AddBlockToMem(block_address, block_size, "x", -old_process_number);
                    old_process_number++;
                    //Sort in Addresses
                    Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
                }
            }
        }
        private void AdjustAddingMethod(bool flag)
        {
            //false for memory and true for backup memory
            if (flag == false)
            {
                // sort by address in first fit
                if (method == 0) Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
                //sort by size in best fit
                else if (method == 1) Memory.Sort((x, y) => x.Key.Value.CompareTo(y.Key.Value));

                // sort by size then reverse it in worst fit
                else
                {
                    Memory.Sort((x, y) => x.Key.Value.CompareTo(y.Key.Value));
                    Memory.Reverse();
                }
            }
            else
            {
                if (method == 0) MemoryBackup.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
                //sort by size in best fit
                else if (method == 1) MemoryBackup.Sort((x, y) => x.Key.Value.CompareTo(y.Key.Value));

                // sort by size then reverse it in worst fit
                else
                {
                    MemoryBackup.Sort((x, y) => x.Key.Value.CompareTo(y.Key.Value));
                    MemoryBackup.Reverse();
                }
            }
        }

        // This Function generate holes that may exist due to allocating segment
        private void GenerateHoleIfExist()
        {
            //Sort in Addresses
            MemoryBackup.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));

            for (int i = 0; i < MemoryBackup.Count; i++)
            {
                int current_address = MemoryBackup[i].Key.Key;
                int current_size = MemoryBackup[i].Key.Value;
                int nxt_address;
                // No Corner Case for first block because it can not contain new hole
                //But this may happen if we deallocate first block
                if((i==0)&&(current_address!=0))
                {
                    int block_address = 0;
                    int block_size = current_address;
                    AddBlockToMemBackup(block_address, block_size, "x", 0);
                    //Sort in Addresses again to avoid this block next iteration time as it is added at the end of list
                    MemoryBackup.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
                }
                //Handel corner case if this last block then i want nxt addres to be memory size
                if (i == (MemoryBackup.Count - 1)) nxt_address = (memory_size-1);
                else nxt_address = MemoryBackup[i + 1].Key.Key;
                //if old process exist
                if ((current_address + current_size) < nxt_address)
                {
                    int block_address = current_address + current_size;
                    int block_size = nxt_address - block_address;
                    //handel last block corner case
                    if(i == (MemoryBackup.Count - 1))block_size++;
                    AddBlockToMemBackup(block_address, block_size, "x", 0);
                    //Sort in Addresses again to avoid this block next iteration time as it is added at the end of list
                    MemoryBackup.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
                }
            }
        }


        private bool IsFit()
        {
            n_segments = Segments.Count;
            AdjustAddingMethod(false);
            int n_of_fited_segments = 0;
            MemoryBackup.Clear();
            MemoryBackup = Memory.ToList();
            //try to allocate all segments of the current process 
            for (int i = 0; i < n_segments; i++)
            {
                for(int j=0;j< MemoryBackup.Count;j++)
                {
                    string segment_name = Segments[i].Key;
                    int segment_size = Segments[i].Value;

                    int memory_block_type = MemoryBackup[j].Value.Value;
                    int memory_block_size = MemoryBackup[j].Key.Value;

                    int memory_block_address = MemoryBackup[j].Key.Key;


                    //check segment fit block and block is hole then if yes replace hole with segment
                    if ((segment_size<=memory_block_size)&&(memory_block_type==0))
                    {
                        KeyValuePair<int, int> kvp1 = new KeyValuePair<int, int>(memory_block_address, segment_size);
                        KeyValuePair<string, int> kvp2 = new KeyValuePair<string, int>(segment_name, procees_number);
                        MemoryBackup[j] = new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>(kvp1, kvp2);
                        GenerateHoleIfExist();
                        AdjustAddingMethod(true);
                        n_of_fited_segments++;
                        break;
                    }
                }
            }
            if (n_of_fited_segments == n_segments) return true;
            return false;
        }


        private void DeallocateProcess(int proceess_number)
        {
            for(int i=0;i<Memory.Count;i++)
            {
                int address = Memory[i].Key.Key;
                int size = Memory[i].Key.Value;
                int type = Memory[i].Value.Value;
                if(procees_number==type)
                {
                    KeyValuePair<int, int> kvp1 = new KeyValuePair<int, int>(address, size);
                    KeyValuePair<string, int> kvp2 = new KeyValuePair<string, int>("x", 0);
                    Memory[i] = new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>(kvp1, kvp2);
                }
            }
            //Twice to handle corner case if there are three holes needeed to be combined
            CombineHoles();
            CombineHoles();
        }



        private void CombineHoles()
        {
            //sort by address
            Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
            for(int i=0;i<(Memory.Count-1);i++)
            {
                int current_address = Memory[i].Key.Key;
                int next_address=Memory[i+1].Key.Key;

                int current_size = Memory[i].Key.Value;
                int next_size = Memory[i + 1].Key.Value;

                int current_type = Memory[i].Value.Value;
                int next_type = Memory[i + 1].Value.Value;
                if((current_type==0)&&(next_type==0))
                {
                    int size = current_size + next_size;
                    KeyValuePair<int, int> kvp1 = new KeyValuePair<int, int>(current_address, size);
                    KeyValuePair<string, int> kvp2 = new KeyValuePair<string, int>("x", 0);
                    Memory[i] = new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<string, int>>(kvp1, kvp2);
                    Memory.RemoveAt(i+1);
                }
            }
        }






        private bool MemorySizeLegal(int memory_size)
        {
            Memory.Sort((x, y) => x.Key.Key.CompareTo(y.Key.Key));
            int address = Memory[Memory.Count - 1].Key.Key;
            int size = Memory[Memory.Count - 1].Key.Value;
            int sum=address+size;
            if (memory_size >= sum) return true;
            return false;
        }
    }
}
