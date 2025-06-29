import { NgModule } from '@angular/core';
import { NgIconsModule } from '@ng-icons/core';
import { matDashboard, matPeopleAlt, matWorkspaces,matFolder, matSettings, matManageAccounts, matLogout } from '@ng-icons/material-icons/baseline';

@NgModule({
  imports: [
    NgIconsModule.withIcons({ matDashboard, matPeopleAlt, matWorkspaces,matFolder, matSettings, matManageAccounts, matLogout })
  ],
  exports: [NgIconsModule]
})
export class IconsModule {}
