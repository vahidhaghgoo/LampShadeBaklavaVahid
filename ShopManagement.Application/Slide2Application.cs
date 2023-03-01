using _0_Framework.Application;
using ShopManagement.Application.Contracts.Slide2;
using ShopManagement.Domain.Slider2Agg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class Slide2Application : ISlide2Application
    {
        private readonly IFileUploader _fileUploader;
        private readonly ISlide2Repository _slide2Repository;
        public Slide2Application(ISlide2Repository slide2Repository, IFileUploader fileUploader)
        {
            _slide2Repository = slide2Repository;
            _fileUploader = fileUploader;
        }
        public OperationResult Create(CreateSlide2 command)
        {
            var operation = new OperationResult();
            var pictureName = _fileUploader.Upload(command.Picture, "slides2");
            var slide = new Slide2(pictureName, command.PictureAlt, command.PictureTitle,
                 command.Title, command.Text, command.Link, command.BtnText);

            _slide2Repository.Create(slide);
            _slide2Repository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditSlide2 command)
        {
            var operation = new OperationResult();
            var pictureName = _fileUploader.Upload(command.Picture, "slides2");
            var slide = _slide2Repository.Get(command.Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            slide.Edit(pictureName, command.PictureAlt, command.PictureTitle,
                command.Title, command.Text, command.Link, command.BtnText);
            _slide2Repository.SaveChanges();
            return operation.Succedded();
        }

        public EditSlide2 GetDetails(long id)
        {
            return _slide2Repository.GetDetails(id);
        }

        public List<Slide2ViewModel> Getlist()
        {
            return _slide2Repository.Getlist();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var slide = _slide2Repository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            slide.Remove();
            _slide2Repository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var slide = _slide2Repository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            slide.Restore();
            _slide2Repository.SaveChanges();
            return operation.Succedded();
        }
    }
}
