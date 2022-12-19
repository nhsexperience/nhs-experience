module Jekyll

	class RawContent < Generator
  
	  def generate(site)
		site.collections.each do |collection|
			collection.each do |label, docs|
				if label.is_a?(Jekyll::Document)
					docs = [label]
				end
				docs.each do |doc|
					doc.data['raw_content'] = doc.content.dup
				end if !docs.nil?
			end
		end
	  end
	
	end
  
  end