using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSchool
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public const string ConnectionString = @"server='DESKTOP-7BIOQ79'; Initial Catalog=ONLINE_SCHOOL;Integrated Security=SSPI";


        private void tanımlamalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSection f = new FrmSection();
            f.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacher f = new FrmTeacher();
            f.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent f = new FrmStudent();
            f.Show();
        }

        private void lessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLesson f = new FrmLesson();
            f.Show();
        }

        private void lessonTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLessonType f = new FrmLessonType();
            f.Show();
        }

        private void teacherSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherSection f = new FrmTeacherSection();
            f.Show();
        }

        private void teacherLessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherLesson f = new FrmTeacherLesson();
            f.Show();
        }

        private void studentLessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentLesson f = new FrmStudentLesson();
            f.Show();
        }

        private void syllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyllabus f = new FrmSyllabus();
            f.Show();
        }

        private void examScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExamSchedule f = new FrmExamSchedule();
            f.Show();
        }

        private void courseDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourseDocuments f = new FrmCourseDocuments();
            f.Show();
        }

        private void studentNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentNotes f = new FrmStudentNotes();
            f.Show();
        }
    }
}
