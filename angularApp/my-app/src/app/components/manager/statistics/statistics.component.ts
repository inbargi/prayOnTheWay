import { Component, OnInit } from '@angular/core';
import { Prayer } from 'src/app/shared/models/prayer.model';
import { PrayerService } from 'src/app/shared/services/prayer.service';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent implements OnInit {

  prayers:Prayer[]=[]
  constructor(private prayerSevice:PrayerService) { }

  ngOnInit(): void {
    this.prayerSevice.getPrayers().subscribe((res:Prayer[])=>this.prayers=res)
  }

}
