using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private EtutDbContext _etutDbContext;
        private SchoolRepository _schoolRepository;
        private TeacherRepository _teacherRepository;


        int okulIndex; //DataGridView seçili satırın kaçıncı satır olduğunu bulmak için
        int ogretmenIndex; // DataGridView seçili satırın kaçıncı satır olduğunu bulmak için
        int aranacakOkulID; // Seçili satırda hangi okulun seçildiğini bulmak ve seçili satırdaki ID' ye göre hareket etmek için yazılan kod
        int aranacakOgretmen; //Seçili satırda hangi okulun seçildiğini bulmak ve seçili satıdaki ID'ye gör hareket etmek için yazılan kod.


        public Form1()
        {
            _etutDbContext = new EtutDbContext();
            _schoolRepository = new SchoolRepository(_etutDbContext);
            _teacherRepository = new TeacherRepository(_etutDbContext);
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOkulEkle_Click(object sender, EventArgs e)
        {
            School school = new School();
            school.NumberOfEmployee = Convert.ToInt32(txtNumberOfEmployee.Text);
            school.NumberOfStudent = Convert.ToInt32(txtNumberOfStudent.Text);
            school.Name = txtSchoolName.Text;
            _schoolRepository.Add(school);
            Clear();
        }


        private void btnOkulListele_Click(object sender, EventArgs e)
        {
            dgwOkul.DataSource = _schoolRepository.GetAll();
        }
 
        private void btnOkulSil_Click(object sender, EventArgs e)
        {
            var silinecekOkul = _schoolRepository.GetByID(aranacakOkulID);
            silinecekOkul.DeletedDate = DateTime.Now;
            _schoolRepository.Delete(silinecekOkul);
            dgwOkul.DataSource = _schoolRepository.GetAll(); // Sildiğim verinin DataGridView'de silinmesi için bu kodu yazıyorum.
        }

        private void dgwOkul_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridView'de seçilen okulun ID bilgisini almak için kullanıyorum.
            okulIndex = dgwOkul.CurrentCell.RowIndex;
            aranacakOkulID = Convert.ToInt32(dgwOkul.CurrentRow.Cells["ID"].Value);
        }


        private void btnOgretmenListele_Click(object sender, EventArgs e)
        {
            dgwOgretmen.DataSource = _teacherRepository.GetAll();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            //Öğretmen Ekleme Metodu 
            Teacher teacher = new Teacher();
            teacher.FirstName = txtAd.Text;
            teacher.Wage = Convert.ToDecimal(txtMaas.Text);
            teacher.LastName = txtSoyad.Text;
            if (rdbEvli.Checked)
            {
                teacher.Married = true;
            }
            else
                teacher.Married = false;
            teacher.NumberOfStudents = Convert.ToInt32(txtOgrSayısı.Text);
            teacher.SchoolID = aranacakOkulID; //Hangi okula öğretmen ekleyeceğimi veriyorum çünkü ikisi ID üzerinden bağlanıyor.Bunu vermezsen nereye eklendiğini kontrol edemem.!!!

            _teacherRepository.Add(teacher);
            Clear();
        }

        private void dgwOgretmen_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridView'de seçilen okulun ID Bilgisini almak için kullanıyorum.
            ogretmenIndex = dgwOgretmen.CurrentCell.RowIndex;
            aranacakOgretmen = Convert.ToInt32(dgwOgretmen.CurrentRow.Cells["ID"].Value);
        }
        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            var silinecekOgretmen = _teacherRepository.GetByID(aranacakOgretmen);
            silinecekOgretmen.DeletedDate = DateTime.Now;
            _teacherRepository.Delete(silinecekOgretmen);
            dgwOgretmen.DataSource = _teacherRepository.GetAll();
        }

        private void btnOkulGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekOkul = _schoolRepository.GetByID(aranacakOkulID);
            guncellenecekOkul.Name = txtSchoolName.Text;
            guncellenecekOkul.NumberOfEmployee = Convert.ToInt32(txtNumberOfEmployee.Text);
            guncellenecekOkul.NumberOfStudent = Convert.ToInt32(txtNumberOfStudent.Text);
            dgwOkul.DataSource = _schoolRepository.GetAll(); //Güncellem işlemi yaptıktan sonra verilerin tekrardan getirilmesin sağladık.
            Clear();

        }

        //Buradaki metot groupbox içerisindeki verilerin temizlenmesi için kullanılmıştır.
        private void Clear()
        {
            foreach (var item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = " ";
            }
            foreach (var item in this.groupBox2.Controls)
            {
                if(item is TextBox)
                    ((TextBox)item).Text = " ";
            }
        }
    }
}
