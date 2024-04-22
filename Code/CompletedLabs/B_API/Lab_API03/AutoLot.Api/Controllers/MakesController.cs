// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Api - MakesController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/04/22
// ==================================

namespace AutoLot.Api.Controllers;

public class MakesController(IAppLogging<MakesController> logger, IMakeRepo repo)
    : BaseCrudController<Make, MakesController>(logger, repo);