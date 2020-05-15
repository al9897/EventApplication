<?php
$page_title="Eventive";
include_once 'Partial/header.php';

?>

<!--Home page style-->
<header id="home" class="home">
    <div class="overlay sections">
        <div class="container">

            <div class="row">
                <div class="wrapper">
                    <div class="col-md-6 col-md-offset-3">

                        <div class="home-details text-center">

                            <div class="logo">
                                <img src="assets/images/logo3.png" alt="Logo Image" style="width: 50%; height: 50%;" />
                            </div>

                            <div class="home-title">
                                <h1><span>FONTYS EINDHOVEN MUSIC</span>Festival</h1>
                            </div>

                            <div class="scroll-down">
                                <h5>Scroll down for more info</h5>
                                <a href="#about"><i class="fa fa-angle-double-down"></i></a>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</header>

        <!-- Sections -->
        <section id="about" class="about sections">
            <div class="container">

                <!-- Example row of columns -->
                <div class="row">
                    <div class="wrapper">
					
                    	<div class="col-md-6">
                    		<div class="about-photo">
								<img src="assets/images/about.jpg" alt="About Image" />
							</div>
                    	</div>
						
						<div class="col-md-6">
                    		<div class="heading about-content">
								<h3>ABOUT FEM</h3>
								<p>Fontys Eindhoven Music Festival-FEM combines the elements of nature, sounds, and visuals. It’s the quintessential family festival located at the footsteps of a world-renowned Stadswandelpark, and it exudes everything it means to be in existence..</p>
								<p>When: January 31th 2019<br>
									Where: Stadswandelpark,Eindhoven.</p>
								<div class="btn-info" style="text-align: center">
									<a href="countdown.php">Check it out</a>
								</div>
							</div>
                    	</div>
						
						
						
                    </div>
                </div>

				<div class="scroll-down">
					<a href="#portfolio"><i class="fa fa-angle-double-down"></i></a>
				</div>
				
            </div> <!-- /container -->       
        </section>
		
		
		<!-- Sections -->
        <section id="portfolio" class="portfolio">
			<div class="overlay sections">
				<div class="container">
				
					<div class="heading text-center">
						<div class="title">
							<h3>Gallery</h3>
						</div>
					</div>
					
					<!-- Example row of columns -->
					
					<div class="row">
						<div class="portfolio-wrapper">
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/1.png" class="portfolio-img"><img src="assets/images/portfolio/1.png" alt="Portfolio" /></a>
								</div>
								
							</div>
								
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/2.png" class="portfolio-img"><img src="assets/images/portfolio/2.png" alt="Portfolio" /></a>
								</div>
								
							</div>

							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/3.png" class="portfolio-img"><img src="assets/images/portfolio/3.png" alt="Portfolio" /></a>
								</div>
								
							</div>

							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/4.png" class="portfolio-img"><img src="assets/images/portfolio/4.png" alt="Portfolio" /></a>
								</div>
								
							</div>

							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/5.png" class="portfolio-img"><img src="assets/images/portfolio/5.png" alt="Portfolio" /></a>
								</div>
								
							</div>
							
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/6.png" class="portfolio-img"><img src="assets/images/portfolio/6.png" alt="Portfolio" /></a>
								</div>
								
							</div>
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/7.png" class="portfolio-img"><img src="assets/images/portfolio/7.png" alt="Portfolio" /></a>
								</div>
								
							</div>
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/8.png" class="portfolio-img"><img src="assets/images/portfolio/8.png" alt="Portfolio" /></a>
								</div>
								
							</div>
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/9.png" class="portfolio-img"><img src="assets/images/portfolio/9.png" alt="Portfolio" /></a>
								</div>
								
							</div>
							<div class="portfolio-item">
							
								<div class="portfolio-details">
									<a href="assets/images/portfolio/10.png" class="portfolio-img"><img src="assets/images/portfolio/10.png" alt="Portfolio" /></a>
								</div>
								
							</div>
								

							
						</div>
					</div>
				</div> <!-- /container -->
			</div>	
        </section>
		
		<section id="contact" class="contact sections">
			<div class="container">
				<div class="row">
					<div class="col-md-6 col-md-offset-3">
						<div class="contact-details text-center">
							<h3>Choose Eventive for your Project</h3>
							<form class='form' id='contact-form' method='post' data-toggle='validator'>
								<input type='hidden' name='form-name' value='contact-form' />
								<div class="messages"></div>
								<div class="controls">
									<div class="row">
										<div class="col-lg-6">
											<div class="form-group">
												<input id="form_name" type="text" name="name" placeholder="Name *" required data-error="name is required.">
												<div class="help-block with-errors"></div>
											</div>
										</div>
										<div class="col-lg-6">
											<div class="form-group">
												<input id="form_email" type="email" name="email" placeholder="Email *" required data-error="Valid email is required.">
												<div class="help-block with-errors"></div>
											</div>
										</div>
										<div class="col-lg-12">
											<div class="form-group">
												<input id="form_subject" type="text" name="subject" placeholder="Subject">
											</div>
										</div>
										<div class="col-lg-12 form-group">
											<textarea id="form_message" name="message" class="form-control" placeholder=" Type Your Message " rows="4" required data-error="Please,leave us a message."></textarea>
											<div class="help-block with-errors"></div>
										</div>
										<div class="col-lg-12 text-center">
											<button class="btn-primary">Send Message</button>
										</div>
									</div>
								</div>
							</form>

							<div class="contact-category">
								<div class="phone">

									<h4>Address :</h4>
									<h6><a target="_blank" href="https://maps.google.com" style="color: #0b0b0b;">Rachelsmolen 1, 5612 MA Eindhoven, Netherlands</a></h6>
								</div>
							</div>
							<div class="contact-category">
								<div class="social">
									<h4>Social Media :</h4>
									<a href="#"><i class="fa fa-facebook"></i></a>
									<a href="#"><i class="fa fa-twitter"></i></a>
									<a href="#"><i class="fa fa-instagram"></i></a>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</section>


        <!--Footer-->
<?php include_once 'Partial/footer.php'?>
    </body>
</html>
