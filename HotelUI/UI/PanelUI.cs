using DataAccess;
using Entities.Concrete;
using Entities.View;
using HotelUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUI.UI
{
    public partial class PanelUI : Form
    {
        public PanelUI()
        {
            InitializeComponent();
        }

        #region Move Form

        private void PanelUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(false, e);
        }

        private void PanelUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void PanelUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(true, e);
        }

        #endregion

        #region Back And Exit

        private void LabelBack_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Back(this);
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack, true);
        }

        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack, false);
        }

        private void LabelExit_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Exit();
        }

        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, true);
        }

        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, false);
        }


        #endregion

        #region Instance

        Authorities authorities = new Authorities();
        AuthorityDal authorityDal = new AuthorityDal();

        BedTypes bedTypes = new BedTypes();
        BedTypeDal bedTypeDal = new BedTypeDal();

        Cards cards = new Cards();
        CardDal cardDal = new CardDal();
        CardView cardView = new CardView();

        Extras extras = new Extras();
        ExtraDal extraDal = new ExtraDal();
        ExtraView extraView = new ExtraView();

        Floors floors = new Floors();
        FloorDal floorDal = new FloorDal();
        FloorView floorView = new FloorView();

        Packages packages = new Packages();
        PackageDal packageDal = new PackageDal();
        PackageView packageView = new PackageView();

        Roles roles = new Roles();
        RoleDal roleDal = new RoleDal();
        RoleView roleView = new RoleView();

        SystemCards systemCards = new SystemCards();
        SystemCardDal systemCardDal = new SystemCardDal();
        SystemCardView systemCardView = new SystemCardView();

        #endregion

        #region Add Authority

        private void buttonAuthorityAdd_Click(object sender, EventArgs e)
        {
            authorities.AuthorityName = textAuthorityName.Text;
            authorities.AuthorityAccessCode = textAuthorityAccessCode.Text;
            authorities.AuthorityIsActive = checkAuthorityActive.Checked;
            authorities.AuthorityDescription = textAuthorityDescription.Text;

            authorityDal.InsertAuthority(authorities);
        }

        #endregion

        #region Delete Authority

        private void buttonAuthorityDelete_Click(object sender, EventArgs e)
        {
            authorities.AuthorityID = Convert.ToInt32(textAuthorityID.Text);
            authorityDal.UpdateAuthority(authorities);

        }

        #endregion

        #region Update Authority

        private void buttonAuthorityUpdate_Click(object sender, EventArgs e)
        {
            authorities.AuthorityID = Convert.ToInt32(textAuthorityID.Text);
            authorities.AuthorityName = textAuthorityName.Text;
            authorities.AuthorityAccessCode = textAuthorityAccessCode.Text;
            authorities.AuthorityDescription = textAuthorityDescription.Text;

            authorityDal.DeleteAuthority(authorities);
        }

        #endregion

        #region List Authority

        private void buttonAuthorityList_Click(object sender, EventArgs e)
        {
            authorities = authorityDal.GetAllAuthorities();
            string[] entity =
            {
                authorities.AuthorityID.ToString(),
                authorities.AuthorityName,
                authorities.AuthorityAccessCode,
                authorities.AuthorityIsActive.ToString(),
                authorities.AuthorityDescription
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            ListViewAuthority.Items.Add(listViewItem);
        }

        #endregion

        #region Add BedType

        private void buttonBedTypeAdd_Click(object sender, EventArgs e)
        {
            bedTypes.BedTypeName = textBedTypeName.Text;
            bedTypes.BedTypeIsActive = checkBedTypeActive.Checked;
            bedTypes.BedTypeDescription = textBedTypeDescription.Text;

            bedTypeDal.InsertBedType(bedTypes);
        }

        #endregion

        #region Add BedType

        private void buttonBedTypeUpdate_Click(object sender, EventArgs e)
        {
            bedTypes.BedTypeID = Convert.ToInt32(textBedTypeID.Text);
            bedTypes.BedTypeName = textBedTypeName.Text;
            bedTypes.BedTypeIsActive = checkBedTypeActive.Checked;
            bedTypes.BedTypeDescription = textBedTypeDescription.Text;

            bedTypeDal.UpdateBedType(bedTypes);
        }

        #endregion

        #region Add BedType

        private void buttonBedTypeDelete_Click(object sender, EventArgs e)
        {
            bedTypes.BedTypeID = Convert.ToInt32(textBedTypeID.Text);

            bedTypeDal.DeleteBedType(bedTypes);
        }

        #endregion

        #region Add BedType

        private void buttonBedTypeList_Click(object sender, EventArgs e)
        {
            bedTypes = bedTypeDal.GetAllBedTypes();
            string[] entity =
            {
                bedTypes.BedTypeID.ToString(),
                bedTypes.BedTypeName,
                bedTypes.BedTypeIsActive.ToString(),
                bedTypes.BedTypeDescription
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            ListViewBedType.Items.Add(listViewItem);
        }

        #endregion

        #region Add Extra 

        private void buttonExtraAdd_Click(object sender, EventArgs e)
        {
            extras.ExtraName = textExtraName.Text;
            extras.ExtraPrice = Convert.ToDecimal(textExtraPrice.Text);
            extras.ExtraIsActive = checkExtraActive.Checked;
            extras.ExtraDescription = textExtraDescription.Text;

            extraDal.InsertExtra(extras);
        }
        #endregion

        #region Update Extra

        private void buttonExtraUpdate_Click(object sender, EventArgs e)
        {
            extras.ExtraID = Convert.ToInt32(textExtraID.Text);
            extras.ExtraName = textExtraName.Text;
            extras.ExtraPrice = Convert.ToDecimal(textExtraPrice.Text);
            extras.ExtraIsActive = checkExtraActive.Checked;
            extras.ExtraDescription = textExtraDescription.Text;

            extraDal.UpdateExtra(extras);
        }

        #endregion

        #region Delete Extra

        private void buttonExtraDelete_Click(object sender, EventArgs e)
        {
            extras.ExtraID = Convert.ToInt32(textExtraID.Text);
            extraDal.DeleteExtra(extras);
        }

        #endregion

        #region List Extra

        private void buttonExtraList_Click(object sender, EventArgs e)
        {
            extraView = extraDal.GetAllExtras();
            string[] entity =
            {
                extraView.ID.ToString(),
                extraView.ExtrasName,
                extraView.Price.ToString(),
                extraView.Activity.ToString(),
                extraView.Descriptions
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            listViewExtra.Items.Add(listViewItem);
        }


        #endregion

        #region Add Floor

        private void buttonFloorAdd_Click(object sender, EventArgs e)
        {
            floors.FloorNumber = textFloorNumber.Text;
            floors.FloorProperties = textFloorProperties.Text;
            floors.FloorIsActive = checkFloorActive.Checked;
            floors.FloorDescription = textFloorDescription.Text;

            floorDal.InsertFloor(floors);
        }

        #endregion

        #region Update Floor

        private void buttonFloorUpdate_Click(object sender, EventArgs e)
        {
            floors.FloorID = Convert.ToInt32(textFloorID.Text);
            floors.FloorNumber = textFloorNumber.Text;
            floors.FloorProperties = textFloorProperties.Text;
            floors.FloorIsActive = checkFloorActive.Checked;
            floors.FloorDescription = textFloorDescription.Text;

            floorDal.UpdateFloor(floors);
        }

        #endregion

        #region Delete Floor

        private void buttonFloorDelete_Click(object sender, EventArgs e)
        {
            floors.FloorID = Convert.ToInt32(textFloorID.Text);
            floorDal.DeleteFloor(floors);
        }

        #endregion

        #region List Floor

        private void buttonFloorList_Click(object sender, EventArgs e)
        {
            floorView = floorDal.GetAllFloors();
            string[] entity =
            {
                floorView.ID.ToString(),
                floorView.Number,
                floorView.Properties,
                floorView.Activity.ToString(),
                floorView.Descriptions
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            listViewFloor.Items.Add(listViewItem);
        }


        #endregion

        


        private void buttonCardAdd_Click(object sender, EventArgs e)
        {
            cards.RoomID = Convert.ToInt32(textRoomID.Text);
            cards.CardIsActive = checkCardActive.Checked;
            cards.CardDescription = textCardDescription.Text;

            cardDal.InsertCard(cards);
        }

        private void buttonCardUpdate_Click(object sender, EventArgs e)
        {
            cards.CardID = Convert.ToInt32(textCardID.Text);
            cards.RoomID = Convert.ToInt32(textRoomID.Text);
            cards.CardIsActive = checkCardActive.Checked;
            cards.CardDescription = textCardDescription.Text;

            cardDal.UpdateCard(cards);
        }

        private void buttonCardDelete_Click(object sender, EventArgs e)
        {
            cards.CardID = Convert.ToInt32(textCardID.Text);
            cardDal.DeleteCard(cards);
        }

        private void buttonCardList_Click(object sender, EventArgs e)
        {
            cardView = cardDal.GetAllCards();
            string[] entity =
            {
                cardView.ID.ToString(),
                cardView.Room.ToString(),
                cardView.Activity.ToString(),
                cardView.Descriptions
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            listViewCard.Items.Add(listViewItem);
        }

        private void buttonPackageAdd_Click(object sender, EventArgs e)
        {
            packages.PackageName = textPackageName.Text;
            packages.PackageProperties = textPackageProperties.Text;
            packages.PackagePrice = Convert.ToDecimal(textPackagePrice.Text);
            packages.PackageIsActive = checkPackageActive.Checked;
            packages.PackageDescription = textPackageDescription.Text;

            packageDal.InsertPackage(packages);
        }

        private void buttonPackageUpdate_Click(object sender, EventArgs e)
        {
            packages.PackageID = Convert.ToInt32(textPackageID.Text);
            packages.PackageName = textPackageName.Text;
            packages.PackageProperties = textPackageProperties.Text;
            packages.PackagePrice = Convert.ToDecimal(textPackagePrice.Text);
            packages.PackageIsActive = checkPackageActive.Checked;
            packages.PackageDescription = textPackageDescription.Text;

            packageDal.UpdatePackage(packages);
        }

        private void buttonPackageDelete_Click(object sender, EventArgs e)
        {
            packages.PackageID = Convert.ToInt32(textPackageID.Text);
            packageDal.DeletePackage(packages);
        }

        private void buttonPackageList_Click(object sender, EventArgs e)
        {
            packageView = packageDal.GetAllPackages();
            string[] entity =
            {
                packageView.ID.ToString(),
                packageView.PackageName,
                packageView.Properties.ToString(),
                packageView.Price.ToString(),
                packageView.Activity.ToString(),
                packageView.Descriptions
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            listViewPackage.Items.Add(listViewItem);
        }

        #region Add Role

        private void buttonRoleAdd_Click(object sender, EventArgs e)
        {
            roles.RoleName = comboRoleName.SelectedValue.ToString();
            roles.RoleIsActive = checkRoleActive.Checked;
            roles.RoleDescription = textRoleDescription.Text;

            roleDal.InsertRole(roles);
        }

        #endregion

        #region Update Role

        private void buttonRoleUpdate_Click(object sender, EventArgs e)
        {
            roles.RoleID = Convert.ToInt32(textRoleID.Text);
            roles.RoleName = comboRoleName.SelectedValue.ToString();
            roles.RoleIsActive = checkRoleActive.Checked;
            roles.RoleDescription = textRoleDescription.Text;

            roleDal.UpdateRole(roles);
        }

        #endregion

        #region Delete Role

        private void buttonRoleDelete_Click(object sender, EventArgs e)
        {
            roles.RoleID = Convert.ToInt32(textRoleID.Text);

            roleDal.DeleteRole(roles);
        }

        #endregion

        #region Role List

        private void buttonRoleList_Click(object sender, EventArgs e)
        {
            roleView = roleDal.GetAllRoles();
            string[] entity =
            {
                roleView.ID.ToString(),
                roleView.RoleType,
                roleView.Activity.ToString(),
                roleView.Descriptions
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            listViewRole.Items.Add(listViewItem);
        }

        #endregion

        #region Add System Card

        private void buttonSystemCardAdd_Click(object sender, EventArgs e)
        {
            
            systemCards.SystemCardAccessCode = textSystemCardAccessCode.Text;
            systemCards.EmployerID = Convert.ToInt32(textEmployerID.Text);
            systemCards.SystemCardIsActive = checkSystemCardActive.Checked;
            systemCards.SystemCardDescription = textSystemCardDescripton.Text;

            systemCardDal.InsertSystemCard(systemCards);
        }

        #endregion

        #region Update System Card

        private void buttonSystemCardUpdate_Click(object sender, EventArgs e)
        {
            systemCards.SystemCardID = Convert.ToInt32(textSystemCardID.Text);
            systemCards.SystemCardAccessCode = textSystemCardAccessCode.Text;
            systemCards.EmployerID = Convert.ToInt32(textEmployerID.Text);
            systemCards.SystemCardIsActive = checkSystemCardActive.Checked;
            systemCards.SystemCardDescription = textSystemCardDescripton.Text;

            systemCardDal.UpdateSystemCard(systemCards);
        }

        #endregion

        #region Delete System Card

        private void buttonSystemCardDelete_Click(object sender, EventArgs e)
        {
            systemCards.SystemCardID = Convert.ToInt32(textSystemCardID.Text);
            systemCardDal.DeleteSystemCard(systemCards);
        }

        #endregion

        #region List System Card

        private void buttonSystemCardList_Click(object sender, EventArgs e)
        {
            systemCardView = systemCardDal.GetAllSystemCards();
            string[] entity =
            {
                systemCardView.ID.ToString(),
                systemCardView.AccessCode,
                systemCardView.EmployerID.ToString(),
                systemCardView.Activity.ToString(),
                systemCardView.Descriptions
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            listViewPackage.Items.Add(listViewItem);
        }

        #endregion

        
    }
}
