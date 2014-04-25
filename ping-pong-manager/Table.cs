using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ping_pong_control {
    class Table {
        public enum Status { Free, Busy, TimesUp }

        public Table(String name) {
            this.name = name;
            this.reset();
        }

        public void reset() {
            this.status = Status.Free;
            this.duration = new TimeSpan();
            this.start_time = DateTime.Now;
        }

        public void start(TimeSpan duration) {
            this.start_time = DateTime.Now;
            this.duration = duration;
            this.status = Status.Busy;
        }

        public void extend(TimeSpan duration) {
            this.duration.Add(duration);
        }

        public void stop() {
            this.status = Status.Free;
        }

        public Status check_status() {
            if (this.status == Status.Busy) {
                if (this.time_left.Ticks <= 0) {
                    this.status = Status.TimesUp;
                }
            }

            return this.status;
        }


        public String name { get; set; }
        public Status status { get; set; }
        public DateTime start_time { get; set; }
        public TimeSpan duration { get; set; }
        public TimeSpan time_left {
            get {
                return this.start_time.Add(this.duration).Subtract(DateTime.Now);
            }
        }
    }
}
