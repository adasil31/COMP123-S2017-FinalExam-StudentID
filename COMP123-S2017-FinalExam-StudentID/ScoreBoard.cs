using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Alessandro da Silva Santos
 * StudentID: 300927354
 * Date: 17/08/2017
 * Description: create a score
 * Version: 0.2 create a score method.;
 */

namespace COMP123_S2017_FinalExam_300927354
{
    public class ScoreBoard
    {

        // Fields private
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        // propriety public
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                ScoreTextBox.Text = Convert.ToString(this._score);
                FinalScoreTextBox.Text = Convert.ToString(this._score);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimeTextBox.Text = Convert.ToString(this._time);
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        // Constructor
        public ScoreBoard(TextBox scoreTextBox, TextBox TimeTextBox, TextBox finalScoreTextBox)
        {

        }
        //private method

        // public method
        /// <summary>
        ///
        /// </summary>
        public void UpdateTime()
        {
            Time = Convert.ToInt32(TimeTextBox.Text) - 1;
            TimeTextBox.Text = Convert.ToString(this.Time);
        }
    }
}

